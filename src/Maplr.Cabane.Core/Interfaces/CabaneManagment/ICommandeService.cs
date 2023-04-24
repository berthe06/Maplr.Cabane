using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maplr.Cabane.Core.Entities;

namespace Maplr.Cabane.Core.Interfaces.CabaneManagment
{
    public interface ICommandeService
    {
        public Task<Response<CommandeVM>> GetCommandeByIdAsync(int commandeId);
        public Task<Response<CommandeVM>> CreateCommandeAsync(CommandeBM model);

        public Task<Response<CommandeVM>> GetCommandeByClientIdAsync(int clientId);

    }
}
