using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsPro
{
    public class Employee
    {
        public void AcceptNames(params string[] names)
        {
            Console.WriteLine("Count " + names.Length);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }


    }
}
