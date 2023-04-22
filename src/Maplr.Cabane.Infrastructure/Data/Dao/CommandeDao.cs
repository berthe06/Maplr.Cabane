using Maplr.Cabane.Core.Entities;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maplr.Cabane.Infrastructure.Data.Dao
{
    public class CommandeDao : RepositoryAsync<Core.Entities.Commande>, ICommandeDao
    {
        public CommandeDao(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        // recuperer le panier dont les elements sont actifs d'un client precis
        public async Task<Commande> GetCommandeByClientId(int clientId)
        {
            var query = await _dbContext.Set<Commande>().Where(t => t.IsActive && t.clientId == clientId).SingleOrDefaultAsync();

            return query;
        }
    }
}
