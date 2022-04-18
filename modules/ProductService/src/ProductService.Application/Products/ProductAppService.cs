using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Products
{
    public class ProductAppService : ProductServiceAppService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> CreateAsync(string text)
        {
            var projectItem = await _productRepository.InsertAsync(new Product { Name = text });

            return new ProductDto
            {
                Id = projectItem.Id,
                Name = projectItem.Name
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductDto>> GetListAsync()
        {
            var items = await _productRepository.GetListAsync();
            return items.Select(item => new ProductDto
            {
                Id = item.Id,
                Name = item.Name
            }).ToList();
        }
    }
}