using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6_simulacroParcial
{
    internal class Intervalo: IComparable<Intervalo> 
    {
        String identificador;
        DateTime inicio;
        DateTime final;
        TimeSpan duracion;


        public Intervalo(String identificador, int anho,int mes,int dia, int hora, int minutos, int anho1, int mes1, int dia1, int hora1, int minutos1)
        {
            this.identificador = identificador;
            this.inicio = new DateTime(anho, mes, dia, hora, minutos, 0);
            this.final = new DateTime(anho1, mes1, dia1, hora1, minutos1, 0);
            this.duracion = final - inicio;
        }

        public Intervalo(String identificador, DateTime inicio, DateTime final)
        {
            this.identificador = identificador;
            this.inicio = inicio;
            this.final = final;
            this.duracion = final - inicio;
        }


        public String Identificador { get => identificador; set => identificador = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Final { get => final; set => final = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }

        public int CompareTo(Intervalo? other)
        {
            return inicio.CompareTo(other.Inicio);
        }

        public override String ToString() 
        {
            return $"Identificador: {identificador}, Intervalo: {inicio} hasta {final}";
        }
    }
}
