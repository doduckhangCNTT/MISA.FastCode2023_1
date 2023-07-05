using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.DL.Repository.Bases
{
    public interface IBaseRepository<TEntity>
    {
        Task<List<TEntity>> EntityFilterAsync(string entityName);

        Task<int> CreateEntity(TEntity entity);
    }
}
