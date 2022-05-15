using Bilfabrik.Models;
using Bilfabrik.Services.StämpelService;
using Microsoft.AspNetCore.Mvc;

namespace Bilfabrik.Controllers
{
    public class StämpelController : Controller
    {
        private readonly IStämpelService _StämpelService;

        public StämpelController(IStämpelService montörService)
        {
            _StämpelService = montörService;
        }
        
        [HttpPost("/add/stämpel")]
        public IActionResult AddStämpel(Stämpel stämpel, int userid)
        {
            _StämpelService.AddStämpel(stämpel,userid);
            return Ok();
        }

        [HttpPut("/update/stämpel")]
        public IActionResult UpdateStämpel(int userid)
        {
            _StämpelService.StämpelUt(userid);
            return Ok();
        }
    }
}
