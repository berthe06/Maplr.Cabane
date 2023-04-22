using Maplr.Cabane.Core.Entities;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Infrastructure.Data.Dao
{
    public  class ProduitDao : RepositoryAsync<Produit>, IProduitDao
    {
        public ProduitDao(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
