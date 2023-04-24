using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Dtos.ViewBindingModel
{
    public class CommandeProduitBM
    {

        public String? Description { get; set; }
        public String Code { get; set; }
        public int Quantite { get; set; }
        public int produitId { get; set; }
        public int commandeId { get; set; }


    }

    public static class CommandeProduitCopyData
    {
        public static CommandeProduit CopyToEntity(this CommandeProduit entity, CommandeProduitBM model)
        {
            entity.Description = model.Description;
            entity.Code = model.Code;
            entity.Quantite = model.Quantite;
            entity.produitId = model.produitId;
            entity.commandeId = model.commandeId;
           


            return entity;
        }
    }
}
