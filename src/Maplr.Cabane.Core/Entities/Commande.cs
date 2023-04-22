using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Entities;
[Table("commande_t_commande")]
public class Commande : BaseEntity
{
  [Column("clientId")]
  public int clientId { get; set; }

  [Column("date")]
  public DateTime date { get; set; }

  [Column("montantCommande")]
  public int montantCommande { get; set; }

  [ForeignKey("clientId")]
  public Client Client { get; set; }


  public ICollection<CommandeProduit> CommandeProduit { get; set; }
}
