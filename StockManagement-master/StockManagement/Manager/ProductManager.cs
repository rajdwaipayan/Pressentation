using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;
using StockManagement.Repository;

namespace StockManagement.Manager
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        CategoryRepository _categoryRepository = new CategoryRepository();

        public List<Category> ComboItem()
        {
            return _categoryRepository.Display();
        }
    }
}
