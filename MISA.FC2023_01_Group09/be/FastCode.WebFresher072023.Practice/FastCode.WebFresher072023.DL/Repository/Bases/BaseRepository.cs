using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FastCode.WebFresher072023.DL.Repository.Bases
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        #region Field
        private readonly string _connectionString; // biến kết nối db
        #endregion

        #region Constructor
        /// <summary>
        /// - Hàm khởi tạo thực hiện cung cấp chuỗi kết nối db
        /// </summary>
        /// <param name="configuration"></param>
        /// CreatedBy: DDKhang (23/5/2023)
        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
        }
        #endregion

        /// <summary>
        /// - Thực hiện mở kết nối đến database
        /// </summary>
        /// <returns>DbConnection</returns>
        /// CreatedBy: DDKhang (23/5/2023)
        public virtual async Task<DbConnection> GetOpenConnectionAsync()
        {
            var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }

        /// <summary>
        /// - Thực hiện lọc thông tin thực thể
        /// </summary>
        /// <param name="entityFilter">Thông tin thực thể lọc</param>
        /// <returns>FilterEntity<TEntity></returns>
        /// Created By: DDKhang (24/6/2023)
        public virtual async Task<List<TEntity>> EntityFilterAsync(string entityName)
        {
            try
            {
                // Lấy tên của thực thể
                string tableName = typeof(TEntity).Name;

                // Khởi tạo kết nối với MariaDb
                using var sqlConnection = await GetOpenConnectionAsync();

                // Khởi tạo danh sách thực thể để lưu lại toàn bộ thông tin được lọc
                List<TEntity> entities = new();

                // Kết nối StoredProcedure - Thực hiện lọc 
                string sqlCommandProcFilter = "Proc_Get" + tableName;

                using (MySqlCommand command = new MySqlCommand(sqlCommandProcFilter, (MySqlConnection?)sqlConnection))
                {
                    // Khai báo sử dụng stored procedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    // Thêm các tham số vào stored procedure (nếu có)
                    command.Parameters.AddWithValue($"@m_{tableName}Title", entityName);

                    // Thực thi stored procedure
                    using MySqlDataReader reader = command.ExecuteReader();

                    // Khởi tạo đối tượng chung TEntity
                    TEntity entity = Activator.CreateInstance<TEntity>();
                    // Danh sách các thuộc tính không hỗ trợ trong TEntity
                    List<string> propertyNoSupport = new() { };

                    // Sử dụng reflection để đặt giá trị cho các thuộc tính của TEntity lấy các thuộc tính của entity
                    PropertyInfo[] properties = typeof(TEntity).GetProperties();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) // Đọc từng bản ghi trong MySqlDataReader
                        {
                            for (int i = 0; i < properties.Length; i++)
                            {
                                // Lấy tên của thuộc tính (của từng cột) từ dữ liệu trả về từ proc
                                PropertyInfo property = properties[i];
                                string propertyName = property.Name;

                                /* Vì trường GenderName không không là thuộc tính trong database mà chỉ là trường bổ sung thêm 
                                 * - Việc kiểm tra thuộc tính "GenderName" là bởi giá trị trả về từ Proc không có trường đó -> không lấy ra được "columnIndex"
                                 * */
                                if (!propertyNoSupport.Contains(propertyName))
                                {
                                    // Kiểm tra xem cột có tồn tại trong dữ liệu đọc được từ Proc hay không
                                    int columnIndex = reader.GetOrdinal(propertyName);
                                    if (columnIndex >= 0 && !reader.IsDBNull(columnIndex))
                                    {
                                        object value = reader.GetValue(columnIndex);
                                        property.SetValue(entity, value);
                                    }
                                }
                            }

                            // Thêm TEntity vào danh sách
                            entities.Add(entity);

                            // Tạo instance mới của TEntity để đọc bản ghi tiếp theo
                            entity = Activator.CreateInstance<TEntity>();
                        }
                    }

                }
                return entities;

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// - Thực hiện thêm thông tin
        /// - Để sử dụng:
        ///     + Tạo Proc mới cho entity muốn thêm ("Proc_Insert" + entityName)
        ///     + Các tham số của các Proc phải giống nhau (m_Name)
        /// </summary>
        /// <param name="entity">Thông tin của thực thể</param>
        /// <returns>Số bản ghi được thêm</returns>
        /// <exception cref="InternalException"></exception>
        /// Created By: DDKhang (24/6/2023)
        public virtual async Task<int> CreateAsync(TEntity entity)
        {
            int qualityAdd = await CreateEntity(entity);
            return qualityAdd;
        }


        /// <summary>
        /// - Hàm thực thể việc thêm thực thể
        /// </summary>
        /// <param name="entity">Thông tin thực thể thêm</param>
        /// <returns>Số lượng bản ghi đã thêm</returns>
        /// <exception cref="Exception"></exception>
        /// Created By: DDKhang (24/6/2023)
        public async Task<int> CreateEntity(TEntity entity)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // Tạo id mới cho nhân viên mới
                    //entity.EmployeeId = Guid.NewGuid();
                    //entity.CreatedBy = "abc";
                    //string inputDate = entity.IdentityDate;

                    // Lấy tên của entity
                    string tableName = typeof(TEntity).Name;

                    // Kết nối database
                    using var sqlConnection = await GetOpenConnectionAsync();
                    //using var mySqlConnection = new MySqlConnection(sqlConnection);
                    //mySqlConnection.Open();

                    string sqlCommandProc = "Proc_Insert" + tableName;
                    // Đọc các tham số đầu vào của store procedure
                    var sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = sqlCommandProc;
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    // Lấy các tham số của Stored Procedure
                    MySqlCommandBuilder.DeriveParameters((MySqlCommand)sqlCommand);

                    var dynamicParam = new DynamicParameters();
                    foreach (MySqlParameter parameter in sqlCommand.Parameters)
                    {
                        // Tên tham số
                        var paramName = parameter.ParameterName;
                        // Bỏ tiền tố "m_" trong tham số
                        var propName = paramName.Replace("@m_", "");
                        // Lấy thuộc tính theo tên trong entity -> kiểm sự tồn tại của thuộc tính trong entity đó
                        var entityProperty = entity?.GetType().GetProperty(propName);
                        if (entityProperty != null)
                        {
                            var propValue = entity?.GetType().GetProperty(propName)?.GetValue(entity);
                            dynamicParam.Add(paramName, propValue);
                        }
                        else
                        {
                            dynamicParam.Add(paramName, null);
                        }
                    }
                    // Số bản ghi được thêm vào
                    var res = sqlConnection.Execute(sql: sqlCommandProc, param: dynamicParam, commandType: System.Data.CommandType.StoredProcedure);

                    if (res > 0)
                    {
                        // Commit Transaction
                        scope.Complete();
                    }
                    return await Task.FromResult(res);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
