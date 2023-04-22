using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Interfaces.ICabaneDao
{
    public interface ICommandeDao : IAsyncRepository<Commande>
    {
        public Task<Commande> GetCommandeByClientId(int  clientId);
    }
}
