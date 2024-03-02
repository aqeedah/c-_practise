using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practise
{
    internal class ItalianChef : Chef //Inheritance
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef can make pasta");
        }
        public virtual void MakeSpecialDish()  // virtual means subclass can make change in this method and it is overwrite of this method of chef class
        {
            Console.WriteLine("The chef makes chicken parm.");
        }
    }
}
