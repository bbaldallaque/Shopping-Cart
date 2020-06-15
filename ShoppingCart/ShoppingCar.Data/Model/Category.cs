using System.Collections.Generic;

namespace ShoppingCar.Data.Model
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ProductCategory> Products { get; set; }
    }
}
