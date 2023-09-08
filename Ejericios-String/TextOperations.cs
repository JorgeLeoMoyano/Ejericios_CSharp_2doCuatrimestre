using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericios_String
{
    internal class TextOperations
    {

        public static int ContarLetras(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            int contador = 0;

            foreach (int letra in letras)
            {
                contador++;
            }

            return 1;
        }

    }
}
