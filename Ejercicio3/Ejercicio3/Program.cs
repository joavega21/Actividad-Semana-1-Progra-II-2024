using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3 {
    class Program {
        static void Main(string[] args) {
            int num = 0, suma = 0;
            Console.WriteLine("Ingrese un numero positivo para sumar: ");
            do {
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                Console.WriteLine("El total de la suma es: {0} ", suma);
            } while (num > 0);
        }
    }
}
