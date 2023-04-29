internal class calculosEstadisticos
{
    private static void Main(string[] args)
    {
        int[] alturas = new int[10];
        float media = 0;
        float[] medias = new float[10];
        float distanciaMedia = 0, desviacionEstandar;
        String alturasDebajo = null, alturasEncima = null, alturasRango = null;


        Console.WriteLine("El programa indicará la varianza y desviacion estandar\n");

        for(int i = 0; i < alturas.Length; i++)
        {
            Console.WriteLine($"Ingrese la altura en cm para la persona {i+1}");
            alturas[i] = int.Parse(Console.ReadLine());
            media += alturas[i];
        }

        media = media / alturas.Length;

        Console.WriteLine("\nLas alturas ingresadas son las siguientes: ");

        for (int i = 0; i < medias.Length; i++)
        {
            medias[i] = (float) Math.Pow((double)alturas[i] - (double)media, 2);
            distanciaMedia += medias[i];
            Console.Write($" {alturas[i]} ;");
        }

        distanciaMedia = distanciaMedia / alturas.Length;
        desviacionEstandar = (float) Math.Round(Math.Sqrt((double)(distanciaMedia)));


        Console.WriteLine($"\n\nLa media es: {media}");
        Console.WriteLine($"La desviacion estandar es: {desviacionEstandar}");

        for (int i = 0; i < alturas.Length; i++)
        {
            if (alturas[i] < media)
            {
                alturasDebajo += $"{alturas[i]} ";
            }
            else if (alturas[i] > media)
            {
                alturasEncima += $"{alturas[i]} ";
            }

            if (alturas[i] > (media - desviacionEstandar) && alturas[i] < (media + desviacionEstandar)) 
            {
                alturasRango += $"{alturas[i]} ";
            }
        }

        Console.WriteLine("\nLas alturas por debajo de la media son: ");
        Console.WriteLine(alturasDebajo);
        Console.WriteLine("\nLas alturas por encima de la media son: ");
        Console.WriteLine(alturasEncima);
        Console.WriteLine($"\nLas alturas dentro del rango ({(media - desviacionEstandar)}), ({media + desviacionEstandar})  definido por la desviacion estandar son: ");
        Console.WriteLine(alturasRango);

    }
}