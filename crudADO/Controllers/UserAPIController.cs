using Dbmodel.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace crudADO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserService _IUserService;
        public UserAPIController(IUserService IUserService)
        {
            _IUserService = IUserService;
        }

        [HttpPost]
        [Route("getUserData")]
        public async Task<IActionResult> getUserData()
        {
            IEnumerable<getUserListData> getUserListData  = new List<getUserListData>();
            getUserListData = await _IUserService.getUserListData();
            return Ok(getUserListData);
        }
    }
}
