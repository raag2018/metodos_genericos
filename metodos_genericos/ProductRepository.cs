using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_genericos{
    public class ProductRepository : IRepository<Product>{
        private readonly List<Product> _products = new List<Product>();
        public void Add(Product item){
            _products.Add(item);
        }
        public Product Get(int id){
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetAll(){
            return _products;
        }
        public void Update(Product item){
            var existingProduct = Get(item.Id);
            if (existingProduct != null){
                existingProduct.Name = item.Name;
                existingProduct.Price = item.Price;
            }
        }
        public void Delete(int id){
            var product = Get(id);
            if (product != null){
                _products.Remove(product);
            }
        }
    }
}
