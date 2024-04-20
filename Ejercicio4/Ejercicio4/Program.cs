using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4 {
    class Program {
        static void Main(string[] args) {
            int num = 0, suma = 0, i = 0;
            Console.WriteLine("Ingrese los valores a sumar : ");
            do {
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            } while (i < 5);
            Console.WriteLine("El total de la suma es: {0} ", suma);
            Console.ReadKey();
        }
    }
}
