using System;
using System.Globalization;

namespace ExerBanco
{
    internal class ContaBancaria
    {

        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            NumeroConta = numero;
            Titular = nome;
            //Saldo = 0;
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial); 
        }

       public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
      
        public void Saque (double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}