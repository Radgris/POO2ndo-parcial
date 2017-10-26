using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndoParcialCOnsole_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nombre");
            var Name = Console.ReadLine();
            Console.WriteLine("edad");
            int Age = Int32.Parse(Console.ReadLine());



            if (Age < 0)
            {
                throw new Exception("edad no valida");

            }

            Console.ReadLine();

        }
    }
}
