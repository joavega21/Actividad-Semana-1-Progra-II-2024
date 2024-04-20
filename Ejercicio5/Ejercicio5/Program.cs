using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5 {
    class Program {
        static void Main(string[] args) {
            Boolean continuar = true;
            double num = 0, i = 0, suma = 0;
            double promedio = 0;
            while (continuar) {
                Console.Write("Ingrese numero positivo: ");
                num = double.Parse(Console.ReadLine());
                suma = suma + num;
                i++;
                Console.Write("Si desea continuar presione cualquier tecla, si desea salir presione 0: ");
                continuar = !Console.ReadLine().Equals("0");
            }
            promedio = suma / i;
            Console.Write("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
