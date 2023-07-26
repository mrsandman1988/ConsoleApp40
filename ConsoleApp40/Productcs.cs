using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public static bool operator ==(Product first, Product second)
        {
            return first.Name == second.Name && first.Price == second.Price;
        }

        public static bool operator !=(Product first, Product second)
        {
            return first.Price != second.Price || first.Name != second.Name;
        }

        public static bool operator > (Product first, Product second)
        {
            return first.Price > second.Price;
        }
        public static bool operator <(Product first, Product second)
        {
            return first.Price > second.Price;
        }

        public static Product operator +(Product first, Product second)
        {
            return new Product
            {
                Id = first.Id,
                Name = first.Name,
                Price = first.Price + second.Price,
                Description = first.Description,
                Discount = first.Discount > second.Discount ? first.Discount : second.Discount
            };

        }
    }
}
