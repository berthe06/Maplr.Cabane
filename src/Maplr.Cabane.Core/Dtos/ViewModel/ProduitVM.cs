using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maplr.Cabane.SharedKernel.EnumUtils;

namespace Maplr.Cabane.Core.Dtos.ViewModel
{
    public class ProduitVM
    {
        public String? Description { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }

        public string prix { get; set; }
        public string image { get; set; }
        public int stock { get; set; }
        public TypeSucre Type { get; set; }
    }


    public static class ProduitCopyData
    {
        public static ProduitVM CopyToModel(this Produit entity)
        {
            ProduitVM model = new()
            {
                Name = entity.Name,
                Description = entity.Description,
                Code = entity.Code,
                prix = entity.prix,
                image = entity.image,
                stock = entity.stock,
      
            };
            return model;
        }
    }
}
