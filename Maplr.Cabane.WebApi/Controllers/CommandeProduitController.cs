using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.SharedKernel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maplr.Cabane.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeProduitController : ControllerBase
    {

        private readonly ICommandeProduitService _commandeProduitService;
        public CommandeProduitController(ICommandeProduitService commandeProduitService)
        {
            _commandeProduitService = commandeProduitService;

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetcommandeById(int Id)
        {
            var result = await _commandeProduitService.GetCommandeProduitByIdAsync(Id);
            if (result.HttpStatus.Equals(MsgUtils.HTTP_500))
            {
                return StatusCode(result.HttpStatus, result);
            }
            return Ok(result);
        }


 
    }
}
