using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Desarrolle un programa que muestre si cada número que se teclea es positivo o negativo,
// y que se detenga cuando al teclear el número 0(usar While).
namespace Ejercicio1 {
    class Program {
        static void Main(string[] args) {
            Boolean continuar = true;
            while (continuar) {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0) {
                    Console.WriteLine("El numero ingresado es negativo");
                } else if (num > 0){
                    Console.WriteLine("El numero ingresado es positivo");
                }else {
                    Console.WriteLine("El valor ingresado no es valido");
                    continuar = !Console.ReadLine().Equals("0");
                }
                //Console.Write("Ingrese cualquier tecla para ingresar otro valor o presione 0 para salir: ");
                
            }
        }
    }
}
