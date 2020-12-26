using Microsoft.AspNetCore.Mvc;
using rapChieuPhim.ViewModels.Catalog.Products;
using rapChieuPhim.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapChieuPhim.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
    }
}