using System;

namespace AulaPOO_Abstracao.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public float Saldo{
            get{ return saldo; }
        }


        public void Pagar(float valor)
        {
            if (this.Valor <= this.Saldo)
            {
                Console.WriteLine($"\nValor da compra: R${this.Valor}");
                Console.WriteLine($"Saldo do cartão: R${this.Saldo}");

                System.Threading.Thread.Sleep(2000);

                Console.WriteLine($"Compra sendo processada");
            }
        }

        public void MostrarCartao()
        {
            Console.WriteLine($"\nSaldo do cartão: R${this.Saldo}");
            Console.WriteLine($"Bnadeira do Cartão: {this.bandeira}");
            Console.WriteLine($"Número do cartão: {this.numero}");
            Console.WriteLine($"Nome do titular: {this.titular}");
        }
    
    }
}