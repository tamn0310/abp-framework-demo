using System;
using Volo.Abp.Domain.Entities;

namespace ProductService
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; }
    }
}