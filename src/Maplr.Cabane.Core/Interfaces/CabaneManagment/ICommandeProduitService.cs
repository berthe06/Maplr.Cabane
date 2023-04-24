using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Interfaces.CabaneManagment
{
    public interface ICommandeProduitService
    {
        public Task<Response<CommandeProduitVM>> GetCommandeProduitByIdAsync(int commandeProduitId);
        public Task<Response<int>> ValidationCommandeAsync(int commandeProduitId);


    }
}
