using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string myname = name ?? "susmitha";
            Console.WriteLine(myname);
            Console.ReadLine();
        }
    }
}
