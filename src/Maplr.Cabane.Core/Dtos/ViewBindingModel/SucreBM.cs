using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Maplr.Cabane.SharedKernel.EnumUtils;

namespace Maplr.Cabane.Core.Dtos.ViewBindingModel
{
    public class SucreBM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string prix { get; set; }
        public string image { get; set; }
        public int stock { get; set; }
        public TypeSucre  type { get; set; }
    }

    public static class SucreCopyData
    {
        public static Sucre CopyTOEntity (this Sucre entity,  SucreBM model)
        {
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Code = model.Code;
            entity.prix = model.prix;
            entity.image = model.image;
            entity.stock = model.stock;
            entity.type = model.type;

            return entity;
        }
        public static SucreVM CopyToModel(this Sucre entity)
        {
            SucreVM model = new();

            model.Id = entity.Id;
            model.Name = entity.Name;
            model.Description = entity.Description;
            model.Code = entity.Code;
            model.prix = entity.prix;
            model.image = entity.image;
            model.stock = entity.stock;
            model.Type = entity.type;

            return model;
        }

    }

}
