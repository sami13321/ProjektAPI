using Bilfabrik.Services.LagledareService;
using Microsoft.AspNetCore.Mvc;

namespace Bilfabrik.Controllers
{
    public class LagledareController : ControllerBase
    {
        private readonly ILagledareService _LagledareService;

        public LagledareController(ILagledareService lagledareService)
        {
            _LagledareService = lagledareService;
        }


        

    }
}
