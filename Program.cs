using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ("Egenii ");
            string surName = ("Maruev");
            string fio = name + surName;
            Console.WriteLine("ФИО : {0}",fio);
            fio = surName + name;
            Console.WriteLine("ФИО : {0}",fio);
        }
    }
}
