using AutoMapper;
using FastCode.WebFresher072023.BL.DTO.Foods;
using FastCode.WebFresher072023.BL.Service.Bases;
using FastCode.WebFresher072023.DL.Entity;
using FastCode.WebFresher072023.DL.Repository.Bases;
using FastCode.WebFresher072023.DL.Repository.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Foods
{
    public class QuestionService : BaseService<Question, QuestionDto, QuestionUpdateDto, QuestionCreateDto>, IQuestionService
    {

        private readonly IQuestionRepository _foodRepository;
        private IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper) : base(questionRepository, mapper)
        {
        }

        //public FoodService(IFoodRepository foodRepository, IMapper mapper) : base(foodRepository, mapper)
        //{
        //    _foodRepository = foodRepository;
        //    _mapper = mapper;
        //    //_foodServiceHobby = foodServiceHobbyService; // Truyền DI 
        //}
    }
}
