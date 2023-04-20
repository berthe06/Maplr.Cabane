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

namespace Maplr.Cabane.Core.Services.CabaneMagement
{
    public class SucreService : ISucreService
    {
        private readonly ISucreDao _sucreDao;
        public async Task<Response<SucreVM>> CreateSucreAsync(SucreBM model)
        {
            string message = MsgUtils.OK;
            SucreVM sucreVM = new();
            Sucre sucre = new();
            try
            {

                sucre = sucre.CopyTOEntity(model);
                sucre.BaseCreate("1", true);
                // sucre.IsAvailable = true;

                if (sucre != null)
                {
                    sucreVM = sucre.CopyToModel();
                }
                await _sucreDao.InsertAsync(sucre);
            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<SucreVM> { Message = message, Total = 0 };
            }

            var response = new Response<SucreVM>
            {
                Message = message,
                Total = 1,
                Data = sucreVM
            };

            return response;
        }

        public async Task<Response<int>> GetSucreByIdAsync(int sucreId)
        {
            string message = MsgUtils.OK;
            Sucre sucre = new();
            try
            {
                sucre = await _sucreDao.GetByIdAsync(sucreId);

                if (sucre == null)
                {
                    return new Response<int> { Message = MsgUtils.NOT_FOUND, Total = 0 };
                }

                sucre.BaseUpdate("1", false);
                await _sucreDao.UpdateAsync(sucre);
            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<int> { Message = message, Total = 0 };
            }

            var response = new Response<int>
            {
                Message = message,
                Total = 1
            };

            return response;
        }
    }
}
