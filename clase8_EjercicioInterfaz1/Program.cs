using clase8_EjercicioInterfaz1;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Libro l1 = new Libro("La Frontera", "Don Winslow");
        Libro l2 = new Libro("El cártel", "Don Winslow");
        Libro l3 = new Libro("El poder del perro", "Don Winslow");
        Libro l4 = new Libro("La Frontera", "Alejo Czombos");
        Libro l5 = new Libro("Adán y Eva", "Paulo Coelho");

        Biblioteca b = new Biblioteca();

        b.Add(l1);
        b.Add(l2);
        b.Add(l3);
        b.Add(l4);
        b.Add(l5);

        b.Add("hola");
        b.Add(5);

        foreach (Libro libro in b)
        {
            libro.Describir();
        }
    }
}