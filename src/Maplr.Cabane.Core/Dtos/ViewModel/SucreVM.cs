using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maplr.Cabane.SharedKernel.EnumUtils;

namespace Maplr.Cabane.Core.Dtos.ViewModel
{
    public class SucreVM : BaseVM
    {

        public string prix { get; set; }
        public string image { get; set; }
        public int stock { get; set; }
        public TypeSucre Type { get; set; }
    }


    public static class SucreCopyData
    {
        public static SucreVM CopyToModel(this Sucre entity)
        {
            SucreVM model = new()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Code = entity.Code,
                prix = entity.prix,
                image = entity.image,
                stock = entity.stock,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedBy = entity.CreatedBy,
                UpdatedBy = entity.UpdatedBy,
                IsActive = entity.IsActive,
            };
            return model;
        }
    }
}
