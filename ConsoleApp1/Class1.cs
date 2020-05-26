using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        private int Id;
        private string Name;

        public Class1(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int getId(){
            return this.Id;
        }

        public string getName(){
            return this.Name;
        }

        public void setId(int Id)
        {
            this.Id = Id;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }


    }
}
