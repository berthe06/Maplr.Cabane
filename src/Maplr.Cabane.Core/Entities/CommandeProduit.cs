using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Entities;
[Table("commandeProduit_t_commandeProduit")]
public class CommandeProduit : BaseEntity
{
  [Column("quantite")]
  public int Quantite { get; set; }

  public int commandeId { get; set; }
  public int produitId { get; set; }

 [ForeignKey("commandeId")]
 public Commande Commande { get; set; }

 [ForeignKey("produitId")]
 public Produit Produit { get; set; }

}
