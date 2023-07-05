using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.DTO.Answers
{
    public class AnswerCreateDto
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
    }
}
