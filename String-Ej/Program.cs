
using System.Text;

namespace String_Ej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string palabra = "hola";
            Console.WriteLine($"la palabra {palabra} tiene {TextOperations.ContarLetras(palabra)} letras");

            //2
            string texto = "Hola buenas tardes";
            Console.WriteLine($"El texto {texto} tiene {TextOperations.ContarPalabras(texto)} palabras");

            //3
            Console.WriteLine($"La palabra {palabra} tiene {TextOperations.ContarVocales(palabra)} vocales");

            //4
            Console.WriteLine($"La palabra {palabra} tiene {TextOperations.ContarConsonantes(palabra)} consonantes");

            //5
            Console.WriteLine($"Texto original {palabra} || texto nuevo {TextOperations.ReemplazarCaracter(palabra,'h' , 'b')}");

            //6
            string numerosEscritos = "12345";
            int numero;
            Console.WriteLine(TextOperations.ConvertirStringAEntero(numerosEscritos,out numero));

            //7
            Console.WriteLine($"StringBuilder : {TextOperations.ConvertirStringASB(palabra)}");

            //8
            Console.WriteLine(TextOperations.ConvertirParrafoASB("El sol brilla en el cielo azul. Las aves vuelan alto. Las flores florecen en el jardín. El verano está en su apogeo."));

            //9
            TextOperations.MostrarTexto(palabra, palabra);

            //10
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El sol brilla en el cielo azul");
            TextOperations.MostrarTextoSB(sb);

        }
    }
}