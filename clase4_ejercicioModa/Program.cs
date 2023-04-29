using clase4_ejercicioModa;

internal class Program
{
    private static void Main(string[] args)
    {
        String numeros = "";
        bool noSalir = true;
        ConsoleKeyInfo tecla;

        Console.WriteLine("Este programa devolvera la moda, el valor minimo y el valor maximo de los valores ingresados.");

        while (noSalir)
        {
            int num;
            bool resultadoConversion;

            Console.WriteLine("\nIngrese un numero:");
            resultadoConversion = int.TryParse(Console.ReadLine(), out num);
            while (!resultadoConversion) 
            {
                Console.WriteLine("No ingreso un numero. Intente nuevamente.");
                Console.WriteLine("Ingrese un numero:");
                resultadoConversion = int.TryParse(Console.ReadLine(), out num);
            }
            numeros += num;

            Console.WriteLine("¿Desea agregar otro numero?");
            Console.WriteLine("S para Si, N para no.");
            Console.Write("Teclee su opcion: ");
            tecla = Console.ReadKey(true);
            Console.WriteLine();

            while(opcionElegida(tecla) == 0) 
            {
                Console.WriteLine("Opcion invalida. Intente nuevamente.");
                Console.WriteLine("¿Desea agregar otro numero?");
                Console.WriteLine("S para Si, N para no.");
                Console.Write("Teclee su opcion: ");
                tecla = Console.ReadKey(true);

            }

            if (opcionElegida(tecla) == 2)
            {
                numeros += ".";
                noSalir = false;
            }
            else numeros += ",";
        }

        Console.Clear();
        Console.WriteLine($"Numeros ingresados: \n{numeros}");

        Estadistica.Moda(numeros);
    }

    private static int opcionElegida(ConsoleKeyInfo tecla) 
    {
        switch(tecla.Key) 
        {
            case ConsoleKey.S: 
                return 1;
                break;
            case ConsoleKey.N: 
                return 2;
            default:
                return 0;
                break;
        }
    }
}