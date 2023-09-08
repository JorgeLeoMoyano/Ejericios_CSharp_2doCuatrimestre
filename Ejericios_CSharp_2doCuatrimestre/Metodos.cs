using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericios_CSharp_2doCuatrimestre
{
    internal class Metodos
    {   /// <summary>
        /// Determina si un numero es o no par 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true : si es par - false : si no es par</returns>
        /// <exception cref="IOException"></exception>
        public static bool DeterminarParidad(int numero)
        {
            bool esPar = false;

            if (numero % 2 == 0)
            {
                esPar = true;
            }
            return esPar; 
        }

        public static void ModificarVector(int[] vector)
        {
            vector[2] = 4444;
        }


    } 
}

