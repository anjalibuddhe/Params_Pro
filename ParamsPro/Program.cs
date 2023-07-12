using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee stud = new Employee();
            stud.AcceptNames("1", "Suraj");
            stud.AcceptNames("Kishor", "Sara", "Pankaj");
            stud.AcceptNames("Anjali", "John", "Hari", "Gita");

        }
    }
}
