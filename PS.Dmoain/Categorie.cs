using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Dmoain
{
    public class Categorie
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public List<Product> products { get; set; }
        
    }
}
