using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Dmoain
{
    public class Provider : Concept
    {

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 20 && value.Length >= 5)
                    password = value;
                else
                    Console.WriteLine("password doit comprendre 5 a 20 char");
            }
        }

        public string confirmPassword;
        public string ConfirmPassword { get { return confirmPassword; } 
            set {
                if (value!=password)
                Console.WriteLine("different");
                else
                    confirmPassword = value;
            } }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        
        
        public string UserName { get; set; }

        public List<Product> products { get; set; }

        //passage par reference
        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = p.Password.Equals(p.ConfirmPassword);
            /*if (p.Password.Equals(p.ConfirmPassword))
                p.IsApproved = true;
            else
                p.IsApproved = false;*/
        }
        //passage par valeur
        public static void SetIsApproved(string pass,string confirmpass,bool isApproved)
        {
            isApproved = pass.Equals(confirmpass);

        }

       /* public bool login(string nom, string pass)
        {
            
            return nom.Equals("admin")&&pass.Equals("admin");
        }
        public bool login(string nom, string pass,string email)
        {

            return UserName.Equals("admin") && Password.Equals(pass)&&Email.Equals(email);
        }*/


        public bool login(string nom, string pass, string email=null)
        {
            if (email == null)
            {
                return nom.Equals("admin") && pass.Equals("admin");
            }

            else
            return UserName.Equals("admin") && Password.Equals(pass) && Email.Equals(email);
        }

        public override void GetDetails()
        {
            Console.WriteLine("Nom="+UserName);
            for(int i = 0; i< products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }
        }

        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Name":
                    foreach (Product p in products)
                    {
                        if (p.Name == filterValue)
                        {
                            Console.WriteLine(p);
                        }
                    }
                        break;
                case "dateProd":
                    foreach(Product p in products)
                    {
                        if(p.DateProd==DateTime.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;
                case "price":
                    foreach (Product p in products)
                    {
                        if (p.Price == double.Parse(filterValue))
                            Console.WriteLine(p);
                    }
                    break;
            }
        }
    }
}
