using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace clase6_simulacroParcial
{
    internal abstract class Solapamientos
    {
        public static List<Intervalo> Calcular(Intervalo[] intervalosDeTiempos)
        {
            int indiceActual = 0;
            List<Intervalo> calculos = new List<Intervalo>();
            calculos.Add(intervalosDeTiempos[0]);

            Array.Sort(intervalosDeTiempos);

            for (int i = 0; i < intervalosDeTiempos.Length; i++) 
            {
                if( i == 0) 
                {
                    calculos[i] = intervalosDeTiempos[indiceActual];
                    continue;
                }

                if (EstanSolapados(calculos[indiceActual],intervalosDeTiempos[i]))
                {
                    Intervalo aux = Unir(calculos[indiceActual], intervalosDeTiempos[i]);
                    calculos[indiceActual] = aux;                }
                else 
                {
                    indiceActual++;
                    calculos.Add(intervalosDeTiempos[i]);
                }
            }
            
            return calculos;
        }

        public static bool EstanSolapados(Intervalo intervalo, Intervalo intervalo1)
        {
            return intervalo.Final > intervalo1.Inicio;
        }

        public static Intervalo Unir(Intervalo intervalo, Intervalo intervalo1) 
        {
            String id = intervalo.Identificador + intervalo1.Identificador;
            DateTime mayor = MayorFin(intervalo, intervalo1);

            return new Intervalo(id, intervalo.Inicio, mayor); 
        }

        public static DateTime MayorFin(Intervalo intervalo, Intervalo intervalo1)
        {
            Intervalo intervaloAux = null;

            if (intervalo.Final > intervalo1.Final)
            {
                intervaloAux = intervalo;
            }
            else if (intervalo1.Final > intervalo.Final)
            {
                intervaloAux = intervalo1;
            }

            return intervaloAux.Final;
        }


    }
}
