using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Entities;
[Table("panier_t_lignePanier")]
public class LignePanier : BaseEntity
{
  [Column("quantite")]
  public int Quantite { get; set; }

  [Column("prix")]
  public int Prix { get; set; }
  public int panierId { get; set; }
  public int sucreId { get; set; }

 [ForeignKey("panierId")]
 public Panier Panier { get; set; }

 [ForeignKey("sucreId")]
 public Sucre Sucre { get; set; }

}
