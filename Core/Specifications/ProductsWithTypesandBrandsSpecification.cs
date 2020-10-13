using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesandBrandsSpecification : BaseSpecification<Product>
    {
        // Get all product.
        public ProductsWithTypesandBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
        // Get single product.
        public ProductsWithTypesandBrandsSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}