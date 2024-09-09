using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        

        public int Numero { get; private set; }
        
        public string  Titular { get; set; }
        
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            //Saldo = saldo;
            //Saldo = depositoInicial;

            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia;
            Saldo = Saldo - 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Títular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}