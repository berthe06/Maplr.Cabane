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
        public int clientId { get; set; }
        public DateTime date { get; set; }
        public int montantCommande { get; set; }

    }

    public static class CommandeSucreCopyData
    {
        public static CommandeProduitVM ToModel(this Commande entity)
        {
            CommandeProduitVM model = new()
            {
                Description = entity.Description,
                Code = entity.Code,
                montantCommande = entity.montantCommande,
                clientId = entity.clientId,
                date = entity.date,

            };
            return model;
        }

    }
}
