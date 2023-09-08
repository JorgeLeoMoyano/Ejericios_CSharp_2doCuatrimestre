namespace Clase3_EJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("--Creacion de cuenta--");

            Console.WriteLine("Ingrese nombre del titular :");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese saldo inicial :");
            if(decimal.TryParse(Console.ReadLine(), out decimal salarioInicial))
            {
                Cuenta cuenta01 = new Cuenta(titular, salarioInicial);
                Console.WriteLine($"Cuenta creada para {titular} con un saldo de {salarioInicial}");

                while (true)
                {
                    Console.WriteLine("\nOperaciones disponibles :");
                    Console.WriteLine("1)Depositar dinero");
                    Console.WriteLine("2)Retirar dinero");
                    Console.WriteLine("3)Salir");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese cantidad que desea acreditar :");
                                if(decimal.TryParse(Console.ReadLine(), out decimal cantidadIngresada))
                                {
                                    cuenta01.IngresarDinero(cantidadIngresada);
                                    Console.WriteLine($"Nuevo saldo: {cuenta01.CuentaToString}");
                                }
                                else 
                                {
                                    Console.WriteLine("Error:Ingrese un monto válido.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Ingrese cantidad a retirar : ");
                                if(decimal.TryParse(Console.ReadLine(),out decimal cantidadARetirar))
                                {
                                    cuenta01.RetirarDinero(cantidadARetirar);
                                    Console.WriteLine($"Nuevo saldo :{cuenta01.getCantidad}");
                                }
                                else
                                {
                                    Console.WriteLine("Error , ingrese un monto válido.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Saliendo del programa...");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                                break;

                        }   

                    }
                    else
                    {
                        Console.WriteLine("ERROR , ingrese un numero de opcion válido");
                    }

                }

            }
            else
            {
                Console.WriteLine("ERROR , el saldo inicial debe ser un numero decimal valido");
            }
        }
    }
}