using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding_Demo
{
    class A
    {
        public string Print()
        {
            return "A";
        }
    }

    class B : A
    {
        public string Print()
        {
            return "B";
        }
    }

    class A2
    {
        public string Print()
        {
            return "A2";
        }
    }

    class B2 : A2
    {
        public new string Print()
        {
            return "B2";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Demo of Method OverRiding
            A a = new A();
            B b = new B();
            A2 a2 = new A2();
            B2 b2 = new B2();
            Debug.WriteLine("\nDemo of overriding...");
            Debug.WriteLine("\n a.Getname : " + a.Print());
            Debug.WriteLine("\n b.Getname : " + b.Print());
            Debug.WriteLine("\n a2.Getname : " + a2.Print());
            Debug.WriteLine("\n b2.Getname : " + b2.Print());

            // Demo of Method Hiding
            A x = new B();
            A2 y = new B2();
            Debug.WriteLine("\n\nDemo of method hiding...");
            Debug.WriteLine("\n x.Getname : " + x.Print());
            Debug.WriteLine("\n y.Getname : " + y.Print());
        }
    }
}
