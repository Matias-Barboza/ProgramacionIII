using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace clase8_EjercicioInterfaz
{
    internal class Libro : IColeccionable, IComparable<Libro>
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

        public int CompareTo(Libro? other)
        {
            if(other == null) return 1;

            if(Titulo.CompareTo(other.Titulo) == 0) 
            {
                return Autor.CompareTo(other.Autor);
            }

            return Titulo.CompareTo(other.Titulo);
        }

        public void Describir()
        {
            Console.WriteLine($"El libro {Titulo} de {Autor} trata de...");
        }
    }
}
