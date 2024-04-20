using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3 {
    class Program {
        static void Main(string[] args) {
            int num = 0, suma = 0;
            Console.WriteLine("Ingrese numeros positivos para sumar o ingrese un valor negativo o 0 para salir: ");
            do {
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            } while (num > 0);
            Console.WriteLine("El total de la suma es: {0} ", suma);
            Console.ReadKey();
        }
    }
}
