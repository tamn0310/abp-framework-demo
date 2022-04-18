using ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductService;

public abstract class ProductServiceController : AbpControllerBase
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
