namespace Clase3_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumno01 = new Estudiante("rodolfo","sanchez",01);
            Estudiante alumno02 = new Estudiante("Pedro", "Mondongo", 02);
            Estudiante alumno03 = new Estudiante("benito", "camesta", 03);

            alumno01.SetNotaPrimerParcial(10);
            alumno01.SetNotaSegundoParcial(10);

            alumno02.SetNotaPrimerParcial(8);
            alumno02.SetNotaSegundoParcial(9);
            alumno03.SetNotaPrimerParcial(4);
            alumno03.SetNotaSegundoParcial(2);

            alumno01.Mostrar();
            alumno02.Mostrar();
            alumno03.Mostrar();
            
        }
    }
}