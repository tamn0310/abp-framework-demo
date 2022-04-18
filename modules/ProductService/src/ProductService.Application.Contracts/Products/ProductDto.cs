using System;
using Volo.Abp.Application.Dtos;

namespace ProductService.Products
{
    public class ProductDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}