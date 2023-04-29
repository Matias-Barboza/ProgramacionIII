using clase6_simulacroParcial;

internal class Program
{
    private static void Main(string[] args)
    {
        //Desde el 1/1/23 23:00:00 a 5/2/2023 12:00:00
        Intervalo intervalo = new Intervalo("A",2023, 1, 1, 23, 0, 2023, 2, 5, 12, 0);

        //Desde el 28/1/23 10:00:00 a 7/3/2023 12:00:00
        Intervalo intervalo1 = new Intervalo("B", 2023, 1, 28, 10, 0, 2023, 3, 7, 12, 0);

        //Desde el 20/3/23 15:30:00 a 1/4/2023 09:00:00
        Intervalo intervalo2 = new Intervalo("C", 2023, 3, 20, 15, 0, 2023, 4, 1, 9, 0);

        //Desde el 15/2/23 14:00:00 a 18/2/2023 18:00:00
        Intervalo intervalo3 = new Intervalo("D", 2023, 2, 15, 14, 0, 2023, 2, 18, 18, 0);

        Intervalo[] intervalosDeTiempo = new Intervalo[] { intervalo3, intervalo1, intervalo2, intervalo };

        List<Intervalo> calculados;


        //foreach (Intervalo inter in intervalosDeTiempo)
        //{
        //    Console.WriteLine(inter);
        //}

        //Array.Sort(intervalosDeTiempo);

        //foreach (Intervalo inter in intervalosDeTiempo)
        //{
        //    Console.WriteLine(inter);
        //}

        calculados = Solapamientos.Calcular(intervalosDeTiempo);

        foreach (Intervalo inter in calculados)
        {
            Console.WriteLine(inter);
        }

    }
}