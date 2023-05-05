using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Herencia
{
    internal class CajaAhorro : CuentaBancaria
    {
        public CajaAhorro(float saldoInicial) : base (saldoInicial)
        {
        
        }

        public override void Depositar(float monto)
        {
            base.Depositar(monto);
        }

        public override void Retirar(float monto)
        {
            if(SaldoDisponible - monto >= 0)
            base.Retirar(monto);
        }
    }
}
