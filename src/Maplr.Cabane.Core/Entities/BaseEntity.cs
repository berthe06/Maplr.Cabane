using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Entities;

public abstract class BaseEntity
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  [Column("description")]
  public string? Description { get; set; }

  [Column("code")]
  public string? Code { get; set; }

  /// <summary>
  ///     userId of created action maker
  /// </summary>
  /// 
  [Column("createdBy")]
  [JsonIgnore]
  public string? CreatedBy { get; set; }

  /// <summary>
  ///     userid of maker user actions
  /// </summary>
  /// 
  [Column("updatedBy")]
  [JsonIgnore]
  public string? UpdatedBy { get; set; }

  [Column("createdAt")]
  [JsonIgnore]
  [Required]
  public DateTime CreatedAt { get; set; }

  [Column("updatedAt")]
  [Required]
  [JsonIgnore]
  public DateTime UpdatedAt { get; set; }

  /// <summary>
  ///     will be use to mark element as deleted elements
  /// </summary>
  /// 
  [Column("isActive")]
  [Required]
  [JsonIgnore]
  public Boolean IsActive { get; set; }

  /// <summary>
  ///     use before update entities
  /// </summary>
  /// <param name="userId"></param>
  /// <param name="isActive"></param>
  public void BaseUpdate(string userId, bool isActive)
  {
    this.UpdatedAt = DateTime.Now;
    this.UpdatedBy = userId;
    this.IsActive = isActive;
  }

  /// <summary>
  ///     use before create element un entity
  /// </summary>
  /// <param name="userId"></param>
  /// <param name="isActive"></param>
  public void BaseCreate(string userId, bool isActive)
  {
    this.CreatedAt = DateTime.Now;
    this.CreatedBy = userId;
    this.UpdatedAt = DateTime.Now;
    this.UpdatedBy = userId;
    this.IsActive = isActive;
  }

}
