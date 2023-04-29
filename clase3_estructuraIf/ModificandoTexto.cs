internal class modificandoTexto
{
    private static void Main(string[] args)
    {
        String texto;
        ConsoleKeyInfo key;
       
        Console.WriteLine("Ingrese el texto a procesar: ");
        texto = Console.ReadLine();

        Console.WriteLine("Desea el texto:");
        Console.WriteLine("1 - En mayusculas");
        Console.WriteLine("2 - En minusculas");
        Console.WriteLine("3 - Texto original");
        key = Console.ReadKey(true);
        Console.WriteLine();

        if (!texto.Equals(""))
        {
            if (key.Key == ConsoleKey.D1)
            {
                Console.WriteLine(texto.ToUpper());
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.WriteLine(texto.ToLower());
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.WriteLine(texto);
            }
        }
        else {
            Console.WriteLine("El texto esta vacio");
        }
    }
}