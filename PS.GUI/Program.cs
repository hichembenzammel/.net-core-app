using System;
using System.Collections.Generic;
using PS.Dmoain;
using PS.Service;
namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "fraise";
            p.DateProd = new DateTime(2022, 1, 31);
            p.DateProd = DateTime.Now; //date system
            Product pc = new Product{
                Name = "ttt",
                Price = 25
            };
            Console.WriteLine(p.Name);
            Console.WriteLine(pc.Name);
            Console.WriteLine(pc.Price);
            Console.WriteLine(p);
            Console.WriteLine(pc);
            Provider pro = new Provider {
                UserName="admin",Password = "admin", ConfirmPassword = "admin",Email="hichemzammel@gmail.com",
            } ;

            Provider progh = new Provider
            {
                Password = "azzzzz",
                ConfirmPassword = "azzzzza"
                
            };
            Console.WriteLine(pro.IsApproved);
            //passage par refference
            //Provider.SetIsApproved(pro);
            //passage par valeur
            Provider.SetIsApproved(pro);
            Console.WriteLine(pro.IsApproved);
            Console.WriteLine("login");
            Console.WriteLine(pro.login("admin", "admin"));
            Product p1 = new Product();
            Chemical c1 = new Chemical();
            Biological b1 = new Biological();
            Console.WriteLine("get type");
            p1.GetMyType();
            c1.GetMyType();
            b1.GetMyType();

            Console.WriteLine("Collection");
            List<Product> products = new List<Product> {
                pc,p
                };
           
            products.Add(pc);
            products.Add(p);

            pro.products = products;
            Console.WriteLine("\n");
            pro.GetDetails();
            p.Price = 200;
            pc.Price = 300;
            Console.WriteLine("Switch \n");
            pro.GetProducts("price","200");

            //Method extension 

            string s = "ss";
            Console.WriteLine(s.Upper());


        }
    }
}
