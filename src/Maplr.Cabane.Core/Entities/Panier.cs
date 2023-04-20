using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Entities;
[Table("panier_t_panier")]
public class Panier : BaseEntity
{
  [Column("clientId")]
  public int clientId { get; set; }

  [ForeignKey("clientId")]
  public Client Client { get; set; }


  public ICollection<LignePanier> LignePaniers { get; set; }
}
