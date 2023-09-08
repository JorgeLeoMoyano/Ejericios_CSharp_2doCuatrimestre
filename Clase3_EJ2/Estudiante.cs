using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_EJ2
{
    internal class Estudiante
    {
        private static Random random; //atributo estatico

        public string _nombre; //propiedades de la clase Estudiante
        public string _apellido;
        public int _legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;



        static Estudiante() //constructor estatico
        {
            random = new Random();
        }

        public Estudiante(string nombre , string apellido , int legajo) //constructor de instancia
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;

        }

        //setter
        public void SetNotaPrimerParcial(int nuevNota)
        {
            notaPrimerParcial = nuevNota;
        }

        public void SetNotaSegundoParcial(int nuevNota2)
        {
            notaSegundoParcial = nuevNota2;
        }

        private float CalcularPromedio()
        {

            float promedio = (float)(notaPrimerParcial + notaSegundoParcial) / 2.0f;
            return promedio;
        }

        public int CalcularNotaFinal()
        {
            int notaFinal;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }

        public void Mostrar()
        {   
            StringBuilder sb = new StringBuilder();
            int notaFinal = CalcularNotaFinal();
            sb.AppendLine($"Nombre :{_nombre}");
            sb.AppendLine($"Apellido :{_apellido}");
            sb.AppendLine($"Legajo :{_legajo}");
            sb.AppendLine($"Nota 1mer parcial :{notaPrimerParcial}");
            sb.AppendLine($"Nota 2do parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio:{CalcularPromedio()}");
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado xd");
            }

            Console.WriteLine(sb.ToString()); 
        }


    }
}
