using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Dtos.ViewModel
{

    public class CommandeProduitVM
    {
        public String? Description { get; set; }
        public String? Code { get; set; }
        public int produitId { get; set; }
        public int commandeId { get; set; }

        public DateTime date { get; set; }
        public int quantite { get; set; }

    }

    public static class CommandeProduitCopyData
    {
        public static CommandeProduitVM ToModel(this CommandeProduit entity)
        {
            CommandeProduitVM model = new()
            {
                Description = entity.Description,
                Code = entity.Code,
                produitId = entity.produitId,
                commandeId = entity.commandeId,
                quantite = entity.Quantite,
                

            };
            return model;
        }

    }
}
