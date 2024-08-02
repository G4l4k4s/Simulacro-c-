using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulacroC_.Models
{
    public static class Validations
    {

        public static int ValidateCapacity(int capacity)
        {
            if (capacity < 1 || capacity > 8)
            {
                Console.WriteLine("Invalid capacity. Please enter a number between 1 and 8.");
            }
                return capacity;
        }

    }
}