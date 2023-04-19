internal class OperacionesBasicas
{
    private static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Ingrese un valor para a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor para a:");
        b = int.Parse(Console.ReadLine());


        Console.WriteLine("Suma: " + (a + b));
        Console.WriteLine("Resta: " + (a - b));
        Console.WriteLine("Multiplicacion: " + (a * b));
        Console.WriteLine("Division: " + (a/ b));
    }
}