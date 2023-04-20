using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Maplr.Cabane.Core.Entities;

[Table("admin_t_users")]
public class Client: BaseEntity
{
    [Column("firstName")]
    public string FirstName { get; set; }

    [Column("lastNme")]
    public string LastName { get; set; }

    [Column("email")] 
    public string Email { get; set; }

    [Column("telephone")]
    public string Telephone { get; set; }


    public ICollection<Panier> Paniers { get; set; }

}
