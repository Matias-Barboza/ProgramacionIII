using clase8_EjercicioInterfaz;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro l1 = new Libro("La Frontera","Don Winslow");
        Libro l2 = new Libro("El cártel", "Don Winslow");
        Libro l3 = new Libro("El poder del perro", "Don Winslow");
        Libro l4 = new Libro("La Frontera", "Alejo Czombos");
        Libro l5 = new Libro("Adán y Eva", "Paulo Coelho");

        Libro[] Biblioteca = { l1, l2, l3 , l4, l5};

        foreach (Libro libro in Biblioteca)
        {
            libro.Describir();
        }

        Array.Sort(Biblioteca);
        Console.WriteLine();

        foreach(Libro libro in Biblioteca) 
        {
            libro.Describir();
        }
    }
}