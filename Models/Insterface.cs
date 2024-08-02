using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public class Insterface
    {
        public static void Header()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("| Welcome to TransRiwi :v |");
            Console.WriteLine(new string('-', 60));

        }


        public static void MostrarSeparador()
        {
            Console.WriteLine(new string('-', 40));
        }

        public static void MostrarPie()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 40));

        }
    }
}