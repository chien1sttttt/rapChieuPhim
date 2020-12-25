using rapChieuPhim.ViewModels.Catalog.Products;
using rapChieuPhim.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rapChieuPhim.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId,GetPublicProductPagingRequest request);
    }
}
