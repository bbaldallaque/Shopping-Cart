using System.Collections.Generic;

namespace ShoppingCar.Data.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ProductImage { get; set; }

        public ICollection<ProductCategory> Categories { get; set; }
    }
}
