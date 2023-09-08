using System.Security.Cryptography;

namespace Clase_3_POO
{
    internal class Program
    {       
            //--PILARES DEL POO--

            //Abstraccion - capacidad de organizar las cosas por tipos
            /*
             Nos permiite obtener una vista mas simple de algo complejo
            hago foco en lo que me importa , descarto lo que no es relevante
            Hay distintos niveles de abstracción nos piermite visualizar distintos aspectos de un objeto / codigo / sistema

            -Identificar las entidades que forman parte de nuestro contexto de negocio o problema a resolver
            -definiar caractersiticas esenciales de una entidad que la distinquen de oros tipos de entidades    
            -Descartar las caracteristicas que no sean relevantes, conservando lo mas importannte

             */

            /*
             * ---CLASES---
             Que es una clase? una clase es una discripcion de 
            un conjunto de objetos que comparten los mismos atributos
            , metodos , relaciones y semantica en un determinado contexto.

            Composicion de una clase:

            --Atributos :
            representan las caracteristicas que son compartidas por todos los objetos de una clase

            --Metodos :
            lo que hace el objeto , acciones y demas 

             */

            //Encapsulamiento - Ocultar del exterior
            //Herencia - una clase hereda las caracteristicas de una clase padre
            //Polimorfismo - las clases hijas pueden modificar metodos de la clase padre, ya sea agregando o quitando cosas

        static void Main(string[] args)
        {
            Celular miCelular;

            //miCelular = new Celular();

            //miCelular.setEstaEncendido(true);
            //Console.WriteLine($"modelo {miCelular.getModelo()} estado {miCelular.getEstaEncendido()} - so:{Celular._sistemaOperativo}");
            //miCelular.setEstaEncendido(false);
        
        }
    }
}