using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Services.CabaneMagement
{
    public class CommandeProduitService : ICommandeProduitService
    {
        public async Task<Response<CommandeProduitVM>> GetCommandeProduitByIdAsync(int commandeProduitId)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<int>> ValidationCommandeAsync(int commandeProduitId) 
        { 
            throw new NotImplementedException();
        }
    }
}
