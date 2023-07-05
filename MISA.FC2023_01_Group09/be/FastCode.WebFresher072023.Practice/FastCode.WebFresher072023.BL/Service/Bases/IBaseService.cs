using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Bases
{
    public interface IBaseService<TEntityDto, TEntityUpdateDto, TEntityCreateDto>
    {
        /// <summary>
        /// - Thực hiện tạo thông tin thực thể mới
        /// </summary>
        /// <param name="entityCreateDto">Thông tin thực thể mới</param>
        /// <returns>Số lượng thực thể đã thêm vào</returns>
        /// CreatedBy: DDKhang (27/6/2023)
        Task<int> CreateAsync(TEntityCreateDto entityCreateDto);

        /// <summary>
        /// - Thực hiện lọc thông tin thực thể
        /// </summary>
        /// <param name="entityFilter">Thông tin lọc</param>
        /// <returns>Danh sách thực thể đã lọc</returns>
        /// CreatedBy: DDKhang (27/6/2023)
        //Task<FilterEntity<TEntityDto>> EntitysFilterAsync(EntityFilter entityFilter);

        Task<List<TEntityDto>> GetAsync(string entityName);
    }
}
