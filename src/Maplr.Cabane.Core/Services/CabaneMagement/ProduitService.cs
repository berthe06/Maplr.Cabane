using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using Maplr.Cabane.SharedKernel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maplr.Cabane.SharedKernel.EnumUtils;

namespace Maplr.Cabane.Core.Services.CabaneMagement
{
    public class ProduitService : IProduitService
    {
        private readonly IProduitDao _produitDao;

        public ProduitService(IProduitDao produitDao)
        {

            _produitDao = produitDao;

        }
        public async Task<Response<ProduitVM>> CreateProduitAsync(ProduitBM model)
        {
            string message = MsgUtils.OK;
            ProduitVM produitVM = new() ;
            Produit produit = new();
            try
            {
                produit = produit.CopyToEntity(model);


                produit.BaseCreate("1", true);

                await _produitDao.InsertAsync(produit);

            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<ProduitVM> { Message = message, Total = 0 };
            }

            var response = new Response<ProduitVM>
            {
                Message = message,
                Total = 1,
            };

            return response;
        }

        public async Task<Response<ProduitVM>> GetProduitByIdAsync(int produitId)
        {
            string message = "ok";
            ProduitVM produitVM = new();
            int total = 0;
            try
            {
                var produit = await _produitDao.GetByIdAsync(produitId);
                if (produit == null)
                {
                    return new Response<ProduitVM>
                    {
                        Total = 0,
                        HttpStatus = MsgUtils.HTTP_404,
                    };
                }
                else
                {
                    produitVM = produit.CopyToModel();
                    return new Response<ProduitVM>
                    {
                        Message = message,
                        Total = total,
                        Data = produitVM,
                        Success = true,
                        HttpStatus = MsgUtils.HTTP_200
                    };
                }
            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<ProduitVM> { Message = message, Total = 0 };
            }

            var response = new Response<ProduitVM>
            {
                Message = message,
                Total = 1,
                Data = produitVM
            };

            return response;
        }
    }
}
