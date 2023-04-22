using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maplr.Cabane.SharedKernel.EnumUtils;

namespace Maplr.Cabane.Core.Entities;

[Table("produit_t_produit")]
public  class Produit : BaseEntity
{
  [Column("name")]
  public string? Name { get; set; }
  [Column("prix")]
  public string? prix { get; set; }

  [Column("image")]
  public string? image { get; set; }

  [Column("stock")]
  public Int32 stock { get; set; }
  [Column("type")]
  public TypeSucre type{ get; set; }


    public ICollection<CommandeProduit> CommandeProduit { get; set; }

}
