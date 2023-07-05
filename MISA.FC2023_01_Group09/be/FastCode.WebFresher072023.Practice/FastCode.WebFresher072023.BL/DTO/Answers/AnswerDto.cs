using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.DTO.Answers
{
    public class AnswerDto
    {
        /// <summary>
        /// - Mã câu trả lời
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public Guid? AnswerId { get; set; }

        /// <summary>
        /// - Tên người trả lời
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? AnswerName { get; set; }

        /// <summary>
        /// - Nội dung câu trả lời
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public string? AnswerContent { get; set; }

        /// <summary>
        /// - Mã câu trả lời
        /// </summary>
        /// Created By: DDKhang (25/6/2023)
        public Guid? QuestionId { get; set; }


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
