using clase4_ejercicioDado;

internal class Program
{
    private static void Main(string[] args)
    {
        int valorElegido = 0;
        Dado dadito = new Dado();
        int resultado;

        Console.WriteLine("Se lanzara un dado, pero ¿Que numero saldra?");
        Console.Write("Teclee su respuesta: (1 a 6): ");
        ConsoleKeyInfo tecla = Console.ReadKey();

        switch(tecla.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                valorElegido = 1;
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                valorElegido = 2;
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                valorElegido = 3;
                break;
            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                valorElegido = 4;
                break;
            case ConsoleKey.D5:
            case ConsoleKey.NumPad5:
                valorElegido = 5;
                break;
            case ConsoleKey.D6:
            case ConsoleKey.NumPad6:
                valorElegido = 6;
                break;
            default:
                Console.WriteLine("\nLo ingresado no es valido");
                Environment.Exit(0); 
                break;
        }

        resultado = dadito.arrojar();


        if(resultado == valorElegido) 
        {
            Console.WriteLine("\nAcertaste");
        }
        else
        {
            Console.WriteLine($"\nEl resultado es: {resultado}");
            Console.WriteLine("No acertaste!");
        }

    }
}