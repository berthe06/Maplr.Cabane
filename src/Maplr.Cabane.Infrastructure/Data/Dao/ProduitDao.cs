using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using Microsoft.EntityFrameworkCore;
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


        /*public  List<Produit>GetProduitByClientType(Type type)
        {

            var query =  GetByQuery(t => t.IsActive && t.type.Equals (type));


            return query.ToList();
        }*/

        public List<Produit> GetProduit()
        {

            var query = GetByQuery(t => t.IsActive);
                query.OrderBy (t => t.type).ToList();



            return query.ToList();
        }



    }


}



