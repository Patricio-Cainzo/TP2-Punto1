using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto1
{
    internal class Cuenta
    {
        public string Titular { get; set; }
        public decimal Cantidad { get; set; }

        public Cuenta(string titular, decimal cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }

        public Cuenta(string titular)
        {
            Titular = titular;
            Cantidad = 0;
        }
        public void Deposito(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Cantidad += cantidad;
            }
            else { }
        }
        public void Retiro(decimal cantidad)
        {

            if (cantidad > Cantidad)
            {
                Cantidad = 0;
            }
            else if (cantidad > 0)
            {
                Cantidad -= cantidad;
            }
            else { }
        }
    }
}
