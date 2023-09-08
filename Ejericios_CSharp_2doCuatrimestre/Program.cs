using System.Text;

namespace Ejericios_CSharp_2doCuatrimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero = 5;

            //if (Metodos.DeterminarParidad(numero) == true)
            //{
            //    Console.WriteLine("el numero es par");
            //}
            //else
            //{
            //    Console.WriteLine("el numerp es impar");
            //}

            //int[] lista = {1, 2, 3, 4 , 5};
            //Metodos.ModificarVector(lista); // lista son mutables , se pueden modificar 
            //foreach (int i in lista)
            //{
            //    Console.WriteLine(i);
            //}

            /*StringBuilder es una clase que se utiliza para construir y 
             * manipular cadenas de texto de manera eficiente,
             * al igual que en otros lenguajes de programación*/
            StringBuilder sb = new StringBuilder();
            string nombre = "pepe";
            string apellido = "ruiz";
            int edad = 40;

            sb.AppendLine($"Su nombre es :{nombre}");
            sb.AppendLine($"Su apellido es :{apellido}");
            sb.AppendLine($"Y su edad es :{edad}");

            Console.WriteLine(sb);

        }
    }
}