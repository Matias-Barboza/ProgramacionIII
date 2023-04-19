using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clase4_ejercicioDado
{
    internal class Dado
    {
        //Los atributos en C# se llaman campos
        private int[] lados = { 1, 2, 3, 4, 5, 6 };
        private Random random = new Random();   

        //Para C# un metodo es aquel que devuelve un tipo de dato, un procedimiento por su parte es void, no devuelve nada 
        public int arrojar() 
        {
            int i = random.Next(0,6);
            return lados[i];
        }
    }
}
