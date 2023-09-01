using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Jose Argento");
            Cuenta cuenta2 = new Cuenta("Monica Argento", 2000);
            Console.WriteLine("La cuenta pertenece a " + cuenta1.Titular + " y contiene : " + cuenta1.Cantidad);
            Console.WriteLine("La cuenta pertenece a " + cuenta2.Titular + " y contiene : " + cuenta2.Cantidad);
            // se ingresa una cantidad positiva y se sumara a la cantidad existente
            cuenta1.Deposito(4000);
            Console.WriteLine("Se hizo un deposito de la cantidad de la cuenta actual es : " + cuenta1.Cantidad);
            // se ingresa una cantidad negativa y la app no hara nada como pide el tp
            cuenta1.Deposito(-4000);
            Console.WriteLine("Se hizo un deposito de la cantidad de la cuenta actual es : " + cuenta1.Cantidad);
            //se retira una cantidad positiva y se resta a la cantidad existente
            cuenta1.Retiro(500);
            Console.WriteLine("Se hizo un retiro la cantidad actual es  : " + cuenta1.Cantidad);
            //se ingresa una cantidad negativa y no se hace nada
            cuenta1.Retiro(-500);
            Console.WriteLine("la cantidad actual es  : " + cuenta1.Cantidad);
            //Si la cantidad a retirar es mayor a la cantidad existente la cuenta queda en 0 como pide el practico
            cuenta1.Retiro(7000);
            Console.WriteLine("Se hizo un retiro la cantidad actual es  : " + cuenta1.Cantidad);

            Console.ReadKey();
        }
    }
}
