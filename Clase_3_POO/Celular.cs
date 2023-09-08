using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_POO
{        /*
         --Que es un objeto?
        los objetos son instancias de clase
        una instancia es una manifestacion concreta de algo
        las clases son el molde o plano a partir de donde se crea una clase
        
         --Que es un constructor?
        un constructor es un metodo especial cuta funcion es darle un valor inicial 
        a los atributos de un objeto para asegurar el correcto funcionamiento del mismo.
        tiene que tener el mismo nombre que la clase
        hay constructores estaticos y no estaticos.
        puedo inicializar los valores por delfault o no
        --Que es un destructor?
        

         */
    internal class Celular
    {
        //por defecto es privado
        //para hacer explicito usamos el modificador de acceso "private"
        //por defecto : ref(objetos -string :NULL)
        // int  :0
        //floar : 00
        //bool:false


    
        public bool _estaEncendido;
        public string _modelo;
        public static string _sistemaOperativo;


        static Celular()
        {
            //lo estatico solamente ve lo estatico
            // se accede directo de la clase
            _sistemaOperativo = "Android 2.5";
        }

        public Celular()
        {
            
        }

        public Celular(bool estaEncendido, string modelo)//Sobrecarga de un constructor
        {
            this._estaEncendido = estaEncendido;
            this._modelo = modelo;
        }

        /*
        ---Modificadores de acceso---
        public - acceso publico , desde cualquiero componente
        private - accesible solo desde la misma clase
        protected - accesible solo desde la misma clase o sus dertivados
        internal - accesible solo desde el mismo proyecto

        --Metodos de acceso--
         
         */

        //GETTER
        public bool getEstaEncendido()
        {
            return this._estaEncendido;
        }

        public string getModelo()
        {
            return this._modelo;
        }
        
        //SETTER
        public void setEstaEncendido(bool value)
        {
            this._estaEncendido = value;
        }

        public void Llamar(string numero)
        {
            if(this._estaEncendido == true)
            {
                Console.WriteLine($"Estoy llamando al numero :{numero}");
            }
            else
            {
                Console.WriteLine("el celular esta apagado , no se puede realizar la llamada pa");
            }
        }






    }
}
