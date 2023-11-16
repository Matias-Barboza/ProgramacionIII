using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase8_EjercicioInterfaz
{
    internal interface IColeccionable
    {
        String Titulo { get; set; }

        void Describir();
    }
}
