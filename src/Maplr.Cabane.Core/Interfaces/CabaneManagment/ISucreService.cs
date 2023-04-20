using Maplr.Cabane.Core.Dtos;
using Maplr.Cabane.Core.Dtos.ViewBindingModel;
using Maplr.Cabane.Core.Dtos.ViewModel;
using Maplr.Cabane.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maplr.Cabane.Core.Interfaces.CabaneManagment
{
    public interface ISucreService
    {
        public Task<Response<int>> GetSucreByIdAsync(int sucreId);
        public Task<Response<SucreVM>> CreateSucreAsync(SucreBM nodel);

    }
}
