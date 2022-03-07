using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Dmoain
{
    public class Chemical : Product
    {
        public override void GetMyType()
        {
            Console.WriteLine();
            base.GetMyType();
            Console.WriteLine(" chemical");

        }
        
    }
}
