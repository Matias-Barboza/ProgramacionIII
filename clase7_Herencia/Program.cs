using clase7_Herencia;

internal class Program
{
    private static void Main(string[] args)
    {
        CajaAhorro cajaAhorro = new CajaAhorro(5000);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(1000, 500);

        cajaAhorro.Depositar(500);

        Console.WriteLine(cajaAhorro.SaldoDisponible);

        cajaAhorro.Retirar(500);

        Console.WriteLine(cajaAhorro.SaldoDisponible);

        cajaAhorro.Retirar(5500);

        Console.WriteLine(cajaAhorro.SaldoDisponible);

        cajaAhorro.Retirar(500);

        Console.WriteLine(cajaAhorro.SaldoDisponible);

        cuentaCorriente.Depositar(500);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);

        cuentaCorriente.Retirar(1000);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);

        cuentaCorriente.Retirar(500);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);

        cuentaCorriente.Depositar(100);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);

        cuentaCorriente.Retirar(1300);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);

        cuentaCorriente.Depositar(600);

        Console.WriteLine(cuentaCorriente.SaldoDisponible);
        Console.WriteLine(cuentaCorriente.SaldoDescubierto);
    }
}