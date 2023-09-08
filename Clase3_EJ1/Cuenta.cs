using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_EJ1
{
    internal class Cuenta
    {
        public string _titular;
        public decimal _cantidad;


        public Cuenta(string titular , decimal cantidad)
        {
            this._titular = titular;
            this._cantidad = cantidad;
        }

        //getter
        public string getTitular()
        {
            return this._titular;
        }

        public decimal getCantidad() 
        {
            return this._cantidad;

        }

        public string CuentaToString()
        {
            string datos = $"Nombre :{this._titular} Cantidad :{this._cantidad}";

            return datos;
        }

        //Setter
        public void IngresarDinero(decimal dinero)
        {
            if (dinero > 0)
            {
                this._cantidad += dinero;
            }
            else
            {
                Console.WriteLine("Error , No se puede ingresar un saldo negativo");
            }
        }

        public void RetirarDinero(decimal monto)
        {
            this._cantidad -= monto;
        }







    }
}
