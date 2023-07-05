using AutoMapper;
using FastCode.WebFresher072023.BL.DTO.Foods;
using FastCode.WebFresher072023.DL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.AutoMapper
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            /*
             - Thực hiện ánh xạ các thuộc tính từ Employee thành các trường tương ứng trong EmployeeDTO (những trường ko được 
            khai báo trong EmployeeDTO thì không được ánh xạ vào)
             */
            CreateMap<Question, QuestionDto>();
            CreateMap<QuestionDto, Question>();
            //CreateMap<FilterEntity<Question>, FilterEntity<QuestionDto>>();
            CreateMap<QuestionCreateDto, Question>();
            CreateMap<QuestionUpdateDto, Question>();
        }
    }
}
