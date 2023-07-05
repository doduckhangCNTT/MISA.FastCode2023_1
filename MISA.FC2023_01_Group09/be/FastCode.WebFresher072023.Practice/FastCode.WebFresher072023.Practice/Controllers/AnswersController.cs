using FastCode.WebFresher072023.BL.DTO.Answers;
using FastCode.WebFresher072023.BL.Service.Answers;
using FastCode.WebFresher072023.DL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FastCode.WebFresher072023.Practice.Controllers
{
    [Route("api/v1/[controller]")]
    public class AnswersController : BaseController<Answer, AnswerDto, AnswerUpdateDto, AnswerCreateDto>
    {
        private readonly string _connectionString;

        public AnswersController(IConfiguration configuration, IAnswerService answerService) : base(answerService)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
        }
    }
}
