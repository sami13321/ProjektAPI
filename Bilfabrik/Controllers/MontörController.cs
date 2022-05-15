using Bilfabrik.Models;
using Bilfabrik.Services;
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


        [HttpGet("{id}")]
        public ActionResult<Montör> GetMontörbyId(int id)
        {
            return _MontörService.GetMontörbyId(id);
            
        }

        [HttpDelete("/delete/" + "{id}")]
        public ActionResult<bool> Delete(int id)
        {
            _MontörService.DeleteMontör(id);
            return true;
        }

        [HttpPut("/update/" + "{id}")]
        public ActionResult<bool> Update(int id, Montör User)
        {
            _MontörService.UpdateMontör(id, User);
            return true;
        }
        
    }
}
