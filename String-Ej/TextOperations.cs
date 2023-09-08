using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Ej
{
    internal class TextOperations
    {
        public static int ContarLetras(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            int contador = 0;

            foreach (char letra in letras)
            {
                contador++;
            }

            return contador;
        }

        public static int ContarPalabras(String texto)
        {   
            string[] palabras = texto.Split(" ");
            int contador = 0;

            foreach (string palabra in palabras)
            {
                contador++;
            }

            return contador;
        }

        public static int ContarVocales(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            int contador = 0;

            foreach (char letra in letras)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int ContarConsonantes(string palabra)
        {
            char[] letras = palabra.ToCharArray();
            int contador = 0;

            foreach (char letra in letras)
            {
                if (letra != 'a' && letra != 'e' && letra != 'i' && letra != 'o' && letra !='u')
                {
                    contador++;
                }
            }

            return contador;

        }

        public static string ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            string nuevaCadena = palabra.Replace(original, nuevo);

            return nuevaCadena;
        }

        public static bool ConvertirStringAEntero(string texto, out int numeroEntero)
        {
            bool retorno = false;

            if (int.TryParse(texto, out numeroEntero))
            {
                retorno = true;
            }
            
            return retorno;
        }

        public static StringBuilder ConvertirStringASB(string palabra)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(palabra);

            return sb;
        }

        public static StringBuilder ConvertirParrafoASB(string parrafo)
        {
            string[] frases = parrafo.Split(".");
            StringBuilder sb = new StringBuilder();
            foreach (string frase in frases)
            {
                sb.AppendLine(frase);
            }

            return sb;
        }

        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine(mensaje + ": " + texto);
        }

        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }
    }
}
