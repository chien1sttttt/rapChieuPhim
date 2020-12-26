using rapChieuPhim.ViewModels.Common;
using rapChieuPhim.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapChieuPhim.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}