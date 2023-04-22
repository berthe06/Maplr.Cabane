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

namespace Maplr.Cabane.Core.Dtos.ViewBindingModel;

    public class ProduitBM 
    {

    public String? Description { get; set; }
    public String Code { get; set; }
    public String Name { get; set; }
    public string prix { get; set; }
    public string image { get; set; }
    public int stock { get; set; }
    public TypeSucre  type { get; set; }
    }

    public static class ProduitCopyData
    {
        public static Produit CopyToEntity(this Produit entity, ProduitBM model)
        {
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Code = model.Code;
            entity.stock = model.stock;
            entity.prix = model.prix;
            entity.image = model.image;
            entity.type = model.type;

        return entity;
        }
    }
