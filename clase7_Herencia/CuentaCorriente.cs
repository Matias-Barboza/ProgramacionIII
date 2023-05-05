using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Herencia
{
    internal class CuentaCorriente : CuentaBancaria
    {
        private float saldoDescubiertoInicial;
        private float saldoDescubierto;

        public CuentaCorriente(float saldoDescubierto)
        {
            SaldoDescubiertoInicial = saldoDescubierto;
            SaldoDescubierto = saldoDescubierto;
        }

        public CuentaCorriente(float saldoDescubierto, float saldoInicial) : base(saldoInicial)
        {
            SaldoDescubiertoInicial = saldoDescubierto;
            SaldoDescubierto = saldoDescubierto;
        }

        public float SaldoDescubiertoInicial { get => saldoDescubiertoInicial; set => saldoDescubiertoInicial = value; }
        public float SaldoDescubierto { get => saldoDescubierto; set => saldoDescubierto = value; }
        
        public override void Depositar(float monto)
        {
            if(SaldoDescubierto != SaldoDescubiertoInicial) 
            {
                if(monto + SaldoDescubierto >= SaldoDescubiertoInicial) 
                {
                    SaldoDescubierto = SaldoDescubiertoInicial;
                    //SaldoDisponible += (SaldoDescubierto + monto) - SaldoDescubiertoInicial;
                    if(monto + SaldoDescubierto > SaldoDescubiertoInicial)
                        base.Depositar((SaldoDescubierto + monto) - SaldoDescubiertoInicial);
                }
                else if(monto + SaldoDescubierto < SaldoDescubiertoInicial)
                {
                    SaldoDescubierto += monto;
                }
            }
            else 
            {
                base.Depositar(monto);
            }

        }

        public override void Retirar(float monto)
        {
            if(SaldoDisponible - monto >= 0)
            {
                base.Retirar(monto);
            }
            else if(SaldoDisponible - monto < 0)
            {
                if(saldoDescubierto - monto >= 0) 
                {
                    SaldoDescubierto -= monto;
                    base.Retirar(monto);
                }
            }
        }

    }
}
