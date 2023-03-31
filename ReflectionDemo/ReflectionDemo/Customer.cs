using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer() 
        {
            Id = 1;
            Name = "Ask";
        }
        public Customer(int id)
        {
            Id=id;
        }
        public void Print()
        {

        }
        public void Test(int a)
        {

        }
    }
}
