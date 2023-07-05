using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.DTO.Foods
{
    public class QuestionDto
    {
        /// <summary>
        /// - Mã code câu hỏi
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public Guid? QuestionId { get; set; }

        /// <summary>
        /// - Tên người hỏi
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? QuestionName { get; set; }

        /// <summary>
        /// - Tiêu đề câu hỏi
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? QuestionTitle { get; set; }

        /// <summary>
        /// - Loại câu hỏi
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public int? QuestionType { get; set; }

        /// <summary>
        /// - Ngày tạo
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// - Người tạo
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? CreatedBy { get; set; }

        /// <summary>
        /// - Ngày sửa
        /// </summary>
        /// Created By: DDKhang (25/6/2023
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// - Người sửa
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? ModifiedBy { get; set; }
    }
}
