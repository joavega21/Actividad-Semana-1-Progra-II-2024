﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3 {
    class Program {
        static void Main(string[] args) {
            int num = 0, suma = 0;
            do {
                Console.WriteLine("Ingrese un numero positivo para sumar: ");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            } while (num > 0);
        }
    }
}