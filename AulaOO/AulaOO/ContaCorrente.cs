using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOO
{
    class ContaCorrente
    {

        private int numero;
        private string titular;
        private float saldo;

        public ContaCorrente(int numero, string titular, float saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public ContaCorrente()
        {
            this.Numero = 0;
            this.Titular = "";
            this.Saldo = 0;
        }

        public void Depositar(float mvalor)
        {
            this.saldo += mvalor;
        }

        public int Sacar(float mvalor)
        {
            this.saldo -= mvalor;
        }

        public float ObterSaldo()
        { return (saldo); }


        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public float Saldo { get => saldo; set => saldo = value; }

    }
}
