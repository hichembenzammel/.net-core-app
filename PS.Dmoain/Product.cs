using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Dmoain
{
    //sealed pour bloquer l'heritage
    public class Product
    {
        public String Description { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }

        public DateTime DateProd { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public override string ToString()
        {
            return "Name= " +Name+" Price= "+Price;
        }
        

        /*  public Product(string description, string name, double price, DateTime dateProd, int productId, int quantity, List<Provider> providers, Categorie categorie)
          {
              Description = description;
              Name = name;
              Price = price;
              DateProd = dateProd;
              ProductId = productId;
              Quantity = quantity;
              Providers = providers;
              Categorie = categorie;
          }*/

        /*public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }*/

        public List<Provider> Providers { get; set; }
        public Categorie Categorie { get; set; }


        public virtual void GetMyType()
        {
            Console.Write( "je suis un produit");
         
        }

        
    }
}
