using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace clase8_EjercicioInterfaz1
{
    internal class Libro: IComparable
    {
    
        private String autor;
        private String titulo;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public Libro(string titulo, string autor)
        {
            Autor = autor;
            Titulo = titulo;
        }

        public void Describir()
        {
            Console.WriteLine($"El libro {Titulo} de {Autor} trata de...");
        }

        public int CompareTo(object? obj)
        {
            Libro l = null;

            if (obj == null) return 1;

            if (obj is Libro) l = (Libro)obj;
            else return 1;

            if (Titulo.CompareTo(l.Titulo) == 0)
            {
                return Autor.CompareTo(l.Autor);
            }

            return Titulo.CompareTo(l.Titulo);
        }
    }
}
