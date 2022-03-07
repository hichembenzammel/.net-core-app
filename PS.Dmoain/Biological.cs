using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Dmoain
{
    public class Biological : Product
    {
        public override void GetMyType()
        {
            base.GetMyType();
            Console.WriteLine(" biological");

        }
    }
}
