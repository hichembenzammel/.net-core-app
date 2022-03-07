using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Dmoain;

namespace PS.Services
{
    public class ManageProduct
    {
        public Func<Char, List<Product>> FindProduct;
        public Action<Categorie> ScanProduct;
        public List<Product> lsProduct { get; set; }
        public ManageProduct()
        {
            //FindProduct = Methode1;
            FindProduct = c =>
            {

                List<Product> ls2Product = new List<Product>();
                foreach (Product p in lsProduct)
                {
                    if (p.Name.StartsWith(c))
                    {
                        ls2Product.Add(p);
                    }

                }
                return ls2Product;

            };

            ScanProduct = cat =>
            {
                foreach (Product p in lsProduct)
                {
                    if (p.Categorie.CategoryId == cat.CategoryId)
                    {
                        Console.WriteLine(p);
                    }
                }
            };
        }
        public List<Product> Methode1(char c)
        {
            List<Product> ls2Product = new List<Product>();
            foreach (Product p in lsProduct)
            {
                if (p.Name.StartsWith("c"))
                {
                    ls2Product.Add(p);
                }

            }
            return ls2Product;
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var req = from p in lsProduct.OfType<Chemical>()
                      where p.Price > price
                      select p;
            return req.Take(5);
            // ignorer les 2 premiers produits 
            //return req.Skip(2);
        }

        public Double GetAveragePrice()
        {
            return lsProduct.Average(p => p.Price);
        }

        public Double GetMaxPrice()
        {
            return lsProduct.Max(p => p.Price);
        }

        public int GetCountProduct()
        {
            return lsProduct.OfType<Chemical>().Count();
        }
    }
}