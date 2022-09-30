using Microsoft.AspNetCore.Mvc;

namespace TrustedNetwork.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return new int[] { 0, 1, 2 };
        }

        [HttpGet("GetByID")]
        public int GetByID(int id)
        {
            return 5;
        }
    }
}
