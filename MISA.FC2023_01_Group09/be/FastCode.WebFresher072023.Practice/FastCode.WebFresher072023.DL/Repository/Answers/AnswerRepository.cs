using FastCode.WebFresher072023.DL.Entity;
using FastCode.WebFresher072023.DL.Repository.Bases;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.DL.Repository.Answers
{
    public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
