using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.SharedKernel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maplr.Cabane.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucreController : ControllerBase
    {
        private readonly ISucreService _sucreService;
        public SucreController(ISucreService sucreService)
        {
            _sucreService = sucreService;
            
        }
        [HttpPost]
        public async Task<ActionResult> CreateSucre([FromForm] SucreBM model)
        {
            if (model== null)
            {
                return BadRequest(MsgUtils.Status_Code400);

            }
            if (ModelState.IsValid)
            {
                
                //create Sucre
                var result = await _sucreService.CreateSucreAsync(model);
                return StatusCode(result.HttpStatus, result);
            }
            return BadRequest(MsgUtils.Status_Code400);
        }

    }
}
