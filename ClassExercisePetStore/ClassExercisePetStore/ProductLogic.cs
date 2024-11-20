using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercisePetStore
{
    internal class ProductLogic
    {

        private List<Product> _products;

        public ProductLogic() 
        {
            _products = new List<Product>(); 
        }
               
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public List<Product> GetAllProducts() 
        {
            return _products;
        }

        Dictionary<string, DogLeash> dogleashes = new Dictionary<string, DogLeash>();
        Dictionary<string, CatFood> catfoods = new Dictionary<string, CatFood>();
    } 
}


    
    
