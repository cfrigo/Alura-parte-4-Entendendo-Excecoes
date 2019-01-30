using System;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {

        }
    }
}
