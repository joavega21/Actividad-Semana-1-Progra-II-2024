using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5 {
    class Program {
        static void Main(string[] args) {
            int promedio = 0, suma = 0, i = 0;
            Console.WriteLine("Ingrese un valor positivo para promediar, o ingrese cero para salir: ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0) {
                suma = suma + num;
                i++;
            }
            promedio = suma / i;
            Console.WriteLine("El promedio de los valores ingresados es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
