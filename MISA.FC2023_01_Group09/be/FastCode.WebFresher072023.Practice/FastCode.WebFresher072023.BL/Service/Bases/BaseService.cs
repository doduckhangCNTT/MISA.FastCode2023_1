using AutoMapper;
using FastCode.WebFresher072023.DL.Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Bases
{
    public class BaseService<TEntity, TEntityDto, TEntityUpdateDto, TEntityCreateDto> : IBaseService<TEntityDto, TEntityUpdateDto, TEntityCreateDto>
    {

        // Khai báo đối tượng DL
        protected readonly IBaseRepository<TEntity> _baseRepository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(TEntityCreateDto entityCreateDto)
        {
            var entityCreate = _mapper.Map<TEntity>(entityCreateDto);

            int res = await _baseRepository.CreateEntity(entityCreate);
            return res;
        }

        public async Task<List<TEntityDto>> GetAsync(string entityName)
        {
            List<TEntity> entities = await _baseRepository.EntityFilterAsync(entityName);

            // Ánh xạ các trường -> Dto
            List<TEntityDto> entitiesDto = _mapper.Map<List<TEntityDto>>(entities);
            return entitiesDto;

        }
    }
}
