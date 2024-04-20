using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5 {
    class Program {
        static void Main(string[] args) {
            Boolean continuar = true;
            int num = 0, i = 0, suma = 0;
            double promedio = 0;
            Console.Write("Ingrese numero positivo para promediar o ingrese 0 para salir: ");
            num = int.Parse(Console.ReadLine());
            while (num >= 0) {

                suma = suma + num;
                i++;
                //Console.WriteLine("Si desea continuar presione cualquier tecla, si desea salir presione 0: ");
                continuar = !Console.ReadLine().Equals("0");
            }
            promedio = suma / i;
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
