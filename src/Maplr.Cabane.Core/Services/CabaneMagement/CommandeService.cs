using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using Maplr.Cabane.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Services.CabaneMagement
{
    public class CommandeService : ICommandeService
    {
        private readonly ICommandeDao _commanderDao;
        public CommandeService(ICommandeDao commandeDao)
        {

            _commanderDao = commandeDao;

        }
        public async Task<Response<CommandeVM>> CreateCommandeAsync(CommandeBM model)
        {
            string message = MsgUtils.OK;
            CommandeVM panierVM = new();
            Commande panier = new();
            try
            {
                panier = panier.CopyToEntity(model);


                panier.BaseCreate("1", true);

                await _commanderDao.InsertAsync(panier);

            }
            catch (Exception e)
            {
                message = MsgUtils.INTERNAL_SERVER_ERROR;
                if (e.InnerException != null)
                {
                    message = message + ' ' + e.InnerException.Message;
                }

                return new Response<CommandeVM> { Message = message, Total = 0 };
            }

            var response = new Response<CommandeVM>
            {
                Message = message,
                Total = 1,
                //Data = panierVM
            };

            return response;
        }


        public async Task<Response<CommandeVM>> GetCommandeByIdAsync(int commandeId)
        {
            string message = "ok";
            CommandeVM panierVM = new();
            int total = 0;
            try
            {
                var panier = await _commanderDao.GetByIdAsync(commandeId);
                if (panier == null)
                {
                    return new Response<CommandeVM>
                    {
                        Total = 0,
                        HttpStatus = MsgUtils.HTTP_404,
                    };
                }
                else
                {
                    panierVM = panier.CopyToModel();
                    return new Response<CommandeVM>
                    {
                        Message = message,
                        Total = total,
                        Data = panierVM,
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

                return new Response<CommandeVM> { Message = message, Total = 0 };
            }

            var response = new Response<CommandeVM>
            {
                Message = message,
                Total = 1,
                Data = panierVM
            };

            return response;
        }



        public async Task<Response<CommandeVM>> GetCommandeByClientIdAsync(int clientId) 
        {
            string message = "ok";
            CommandeVM panierVM = new();
            int total = 0;
            try
            {
                Commande panier = await _commanderDao.GetCommandeByClientId(clientId);
                if (panier == null)
                { 
                    return new Response<CommandeVM>
                    {
                        Total = 0,
                        HttpStatus = MsgUtils.HTTP_404,
                    };
                }
                else
                {
                    panierVM = panier.CopyToModel();
                    return new Response<CommandeVM>
                    {
                        Message = message,
                        Total = total,
                        Data = panierVM,
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

                return new Response<CommandeVM> { Message = message, Total = 0 };
            }

            var response = new Response<CommandeVM>
            {
                Message = message,
                Total = 1,
                Data = panierVM
            };

            return response;
        }
    }
}
