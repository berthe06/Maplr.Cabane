using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Dtos.ViewBindingModel
{
    public class CommandeBM
    {

        public String? Description { get; set; }
        public String Code { get; set; }
        public int clientId { get; set; }
        public DateTime date { get; set; }
        public int montantCommande{ get; set; }

    }

    public static class CommandeClientCopyData
    {
        public static Commande CopyToEntity(this Commande entity, CommandeBM model)
        {
            entity.Description = model.Description;
            entity.Code = model.Code;
            entity.date = model.date;
            entity.clientId = model.clientId;
            entity.montantCommande = model.montantCommande;


            return entity;
        }
    }
}
