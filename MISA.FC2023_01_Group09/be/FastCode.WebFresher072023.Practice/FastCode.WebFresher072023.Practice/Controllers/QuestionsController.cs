using FastCode.WebFresher072023.BL.DTO.Foods;
using FastCode.WebFresher072023.BL.Service.Bases;
using FastCode.WebFresher072023.BL.Service.Foods;
using FastCode.WebFresher072023.DL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FastCode.WebFresher072023.Practice.Controllers
{
    [Route("api/v1/[controller]")]
    public class QuestionsController : BaseController<Question, QuestionDto, QuestionUpdateDto, QuestionCreateDto>
    {
        private readonly string _connectionString;

        public QuestionsController(IConfiguration configuration, IQuestionService foodService) : base(foodService)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
        }
    }
}
