using System.Collections.Generic;

namespace ASPPatterns.Chap2.Service
{
    public class ProductRepository
    {
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products = new List<Product>();
            // Database operation to populate products …
            return products;
        }
    }
}
