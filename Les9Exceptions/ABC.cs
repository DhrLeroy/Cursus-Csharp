using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les9Exceptions
{
    public class A
	{
        public void Do() {
            //try
            //{
                new B().Do();
            //}
            //catch
            //{
            //    Console.WriteLine("Er is iets foutgelopen in klasse A.");
            //}
            
        }
 	}
    public class B
    {
         public void Do() => new C().Do();
    }
    public class C
    {
        public int Do() => 1 / Int32.Parse("0");
    }

}
