using AutoMapper;
using FastCode.WebFresher072023.BL.DTO.Answers;
using FastCode.WebFresher072023.BL.Service.Bases;
using FastCode.WebFresher072023.DL.Entity;
using FastCode.WebFresher072023.DL.Repository.Answers;
using FastCode.WebFresher072023.DL.Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Answers
{
    public class AnswerService : BaseService<Answer, AnswerDto, AnswerUpdateDto, AnswerCreateDto>, IAnswerService
    {

        private readonly IAnswerRepository _answerRepository;
        private IMapper _mapper;

        public AnswerService(IAnswerRepository answerRepository, IMapper mapper) : base(answerRepository, mapper)
        {
        }
    }
}
