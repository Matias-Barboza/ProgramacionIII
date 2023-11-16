using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_EjercicioInterfaz1
{
    internal class Biblioteca : IEnumerable, IList, ICollection
    {
        private ArrayList libros;

        public Biblioteca()
        {
            this.libros = new ArrayList();
        }

        public object? this[int index] { get => this[index]; set => this[index] = value; }

        public bool IsFixedSize => libros.IsFixedSize;

        public bool IsReadOnly => libros.IsReadOnly;

        public int Count => libros.Count;

        public bool IsSynchronized => libros.IsSynchronized;

        public object SyncRoot => libros.SyncRoot;

        public int Add(object? value)
        {
            if (value is Libro) value = (Libro)value;
            else return -1;
            return libros.Add(value);
        }

        public void Clear()
        {
            libros.Clear();
        }

        public bool Contains(object? value)
        {
            if (value is Libro) value = (Libro)value;
            else return false;
            return libros.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            libros.CopyTo(array, index);
        }


        public int IndexOf(object? value)
        {
            if (value is Libro) value = (Libro)value;
            else return -1;
            return libros.IndexOf(value);
        }

        public void Insert(int index, object? value)
        {
            libros.Insert(index, value);
        }

        public void Remove(object? value)
        {
            libros.Remove(value);
        }

        public void RemoveAt(int index)
        {
            libros.RemoveAt(index);
        }
        public IEnumerator GetEnumerator()
        {
            return libros.GetEnumerator();
        }

    }
}
