using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Parent
    {
        public void M1()
        {
            Console.WriteLine("Inside Parent Class");
        }
    }

    class Child : Parent
    {
        public void M2()
        {
            Console.WriteLine("Inside Child Class");
        }
    }
}
