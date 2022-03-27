using Bilfabrik.Models;
using Bilfabrik.Services.MontörService;
using Microsoft.AspNetCore.Mvc;

namespace Bilfabrik.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MontörController : ControllerBase
    {
        private readonly IMontörService _MontörService;

        public MontörController(IMontörService montörService)
        {
            _MontörService = montörService;
        }

        [HttpPut("/addmontör")]

        public ActionResult<bool> Add(Montör NewUser)
        {
            _MontörService.Add(NewUser);
            return true;
        }
    }
}
