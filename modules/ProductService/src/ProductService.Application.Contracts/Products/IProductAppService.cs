using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductService.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<List<ProductDto>> GetListAsync();

        Task<ProductDto> CreateAsync(string text);

        Task DeleteAsync(Guid id);
    }
}