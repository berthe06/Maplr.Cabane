using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.Core.Services.CabaneMagement;
using Maplr.Cabane.SharedKernel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maplr.Cabane.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {
        private readonly ICommandeService _commandeService;
        public CommandeController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
            
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetcommandeById(int Id)
        {
            var result = await _commandeService.GetCommandeByIdAsync(Id);
            if (result.HttpStatus.Equals(MsgUtils.HTTP_500))
            {
                return StatusCode(result.HttpStatus, result);
            }
            return Ok(result);
        }

        
        [HttpPost]
        public async Task<ActionResult> CreateCommande([FromForm] CommandeBM model)
        {
            if (model == null)
            {
                return BadRequest(MsgUtils.Status_Code400);

            }
            if (ModelState.IsValid)
            {

                //create Sucre
                var result = await _commandeService.CreateCommandeAsync(model);
                return StatusCode(result.HttpStatus, result);
            }
            return BadRequest(MsgUtils.Status_Code400);
        }
    }
}
