using AutoMapper;
using FastCode.WebFresher072023.BL.DTO.Answers;
using FastCode.WebFresher072023.DL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.AutoMapper
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {

            /*
             - Thực hiện ánh xạ các thuộc tính từ Employee thành các trường tương ứng trong EmployeeDTO (những trường ko được 
            khai báo trong EmployeeDTO thì không được ánh xạ vào)
             */
            CreateMap<Answer, AnswerDto>();
            CreateMap<AnswerDto, Answer>();
            //CreateMap<FilterEntity<Answer>, FilterEntity<AnswerDto>>();
            CreateMap<AnswerCreateDto, Answer>();
            CreateMap<AnswerUpdateDto, Answer>();
        }
    }
}
