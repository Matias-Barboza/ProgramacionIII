using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase7_Herencia
{
    internal abstract class CuentaBancaria
    {
        private String nombreTitular;
        private String dniTitular;
        private String numCuenta;
        private static int numCuentaEntero = 100;
        private float saldoDisponible;

        public CuentaBancaria() 
        {
            numCuenta = Convert.ToString(numCuentaEntero);
            numCuentaEntero++;
        }

        public CuentaBancaria(float saldoInicial)
        {
            SaldoDisponible = saldoInicial;
            numCuenta = Convert.ToString(numCuentaEntero);
            numCuentaEntero++;
        }

        public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }
        public string DniTitular { get => dniTitular; set => dniTitular = value; }
        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public static int NumCuentaEntero { get => numCuentaEntero; set => numCuentaEntero = value; }
        public float SaldoDisponible { get => saldoDisponible; set => saldoDisponible = value; }

        public virtual void Depositar(float monto) 
        {
            SaldoDisponible += monto;
        }

        public virtual void Retirar(float monto) 
        {
            SaldoDisponible -= monto;
        }
    }
}
