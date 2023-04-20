using System;

namespace Maplr.Cabane.Core.Dtos;
public class BaseVM
{
  public int Id { get; set; }
  public String? Description { get; set; }
  public String Code { get; set; }
  public String Name { get; set; }
  public String CreatedBy { get; set; }
  public String UpdatedBy { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public Boolean IsActive { get; set; }
}
