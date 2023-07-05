using FastCode.WebFresher072023.BL.DTO.Foods;
using FastCode.WebFresher072023.BL.Service.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Foods
{
    public interface IQuestionService : IBaseService<QuestionDto, QuestionUpdateDto, QuestionCreateDto>
    {
    }
}
