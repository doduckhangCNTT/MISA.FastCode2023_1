using FastCode.WebFresher072023.BL.Service.Bases;
using Microsoft.AspNetCore.Mvc;

namespace FastCode.WebFresher072023.Practice.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TEntityDto, TEntityUpdateDto, TEntityCreateDto> : ControllerBase
    {
        #region Field
        // Khai báo đối tượng gọi lên tầng service
        protected readonly IBaseService<TEntityDto, TEntityUpdateDto, TEntityCreateDto> _baseService;
        //protected readonly IFoodServiceHobbyService _foodServiceHobbyService;
        #endregion

        #region Constructor
        protected BaseController(IBaseService<TEntityDto, TEntityUpdateDto, TEntityCreateDto> baseService)
        {
            _baseService = baseService;
        }
        #endregion

        /// <summary>
        /// - Thực hiện thêm thông tin thực thể
        /// </summary>
        /// <param name="entityCreateDto">Thông tin thực thể muốn thêm</param>
        /// <returns>Số bản ghi đã thêm</returns>
        /// CreatedBy: DDKhang (27/6/2023)
        [HttpPost()]
        public virtual async Task<ActionResult<int>> CreateAsync(TEntityCreateDto entityCreateDto)
        {
            int qualityRecordsCreate = await _baseService.CreateAsync(entityCreateDto);
            return Ok(qualityRecordsCreate);
        }

        /// <summary>
        /// - Thực hiện lấy thông tin thực thể
        /// </summary>
        /// <param name="entityCreateDto">Thông tin thực thể muốn thêm</param>
        /// <returns>Số bản ghi đã thêm</returns>
        /// CreatedBy: DDKhang (27/6/2023)
        [HttpGet]
        public virtual async Task<ActionResult<List<TEntityDto>>> GetAsync(string? entityName)
        {
            List<TEntityDto> entities = await _baseService.GetAsync(entityName);
            return Ok(entities);
        }


    }
}
