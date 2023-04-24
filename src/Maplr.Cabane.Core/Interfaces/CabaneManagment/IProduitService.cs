using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Interfaces.CabaneManagment
{
    public interface IProduitService
    {
        public Task<Response<ProduitVM>> GetProduitByIdAsync(int produitId);
        public Task<Response<ProduitVM>> CreateProduitAsync(ProduitBM nodel);

        //public Task<Response<List<ProduitVM>>> GetProduitAsync();

        public Response<List<ProduitVM>> GetProduitAsync();




    }
}
