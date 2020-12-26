using rapChieuPhim.ViewModels.Common;
using rapChieuPhim.ViewModels.System.Languages;
using rapChieuPhim.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace rapChieuPhim.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}