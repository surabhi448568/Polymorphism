using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Subclass S = new Subclass();
            Superclass sc = new Superclass();
            //S.MethodSuper();
            //S.ExecuteSuper();
            //S.MethodSuper();
            //S.ExecuteSuper();

            //((Superclass)S).MethodSuper(); // way to re-implement base class method from child class obj

            sc.MethodSuper();
        }
    }

    class Superclass
    {
       //public virtual void MethodSuper()   //Method Overriding
       // {
       //     System.Console.WriteLine("Execute Method from Super");
       //     System.Console.ReadLine();
       // }
        public void MethodSuper()   //Method Hiding
        {
            System.Console.WriteLine("Execute Method from Super");
            System.Console.ReadLine();
        }
    }

    class Subclass:Superclass
    {
        //public override void MethodSuper()
        //{
        //    System.Console.WriteLine("Execute Method from Sub");
        //    System.Console.ReadLine();
        //}
        public new void MethodSuper() // Method Hiding
        {
            System.Console.WriteLine("Execute Method from Sub");
            System.Console.ReadLine();
        }
        public void ExecuteSuper()   // baseclass method can only be called from inside subclass
        {
            base.MethodSuper();
          
        }

    }
}
