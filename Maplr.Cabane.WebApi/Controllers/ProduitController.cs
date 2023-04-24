using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.SharedKernel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maplr.Cabane.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitService _produitService;
        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;

        }
        [HttpPost]
        public async Task<ActionResult> CreateProduit([FromForm] ProduitBM model)
        {
            if (model == null)
            {
                return BadRequest(MsgUtils.Status_Code400);

            }
            if (ModelState.IsValid)
            {

                //create Sucre
                var result = await _produitService.CreateProduitAsync(model);
                return StatusCode(result.HttpStatus, result);
            }
            return BadRequest(MsgUtils.Status_Code400);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetProduitById(int Id)
        {
            var result = await _produitService.GetProduitByIdAsync(Id);
            if (result.HttpStatus.Equals(MsgUtils.HTTP_500))
            {
                return StatusCode(result.HttpStatus, result);
            }
            return Ok(result);
        }


        [HttpGet]
        public  Response<List<ProduitVM>> GetProduit()
        {
            var result =  _produitService.GetProduitAsync();
            if (result.HttpStatus.Equals(MsgUtils.HTTP_500))
            {
                //return StatusCode( result);
            }
            return (result);
        }
    }
}
