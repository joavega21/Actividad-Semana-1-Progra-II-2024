﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5 {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            double promedio = 0, suma = 0;
            Boolean continuar = true;
            Console.WriteLine("Ingrese valores positivos para promediar, o ingrese cero para salir: ");
            while (continuar) {
                double num = double.Parse(Console.ReadLine());
                suma = suma + num;
                i++;
                continuar = !Console.ReadLine().Equals("0");
            }
            promedio = suma / i;
            Console.WriteLine("El promedio de los valores ingresados es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
