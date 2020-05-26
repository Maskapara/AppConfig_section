using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2 : Class1
    {
        public Class2(int Id,string Name) :base(Id,Name)
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello,World");
        }
    }
}
