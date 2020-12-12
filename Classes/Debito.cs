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
            if (this.Valor > this.Saldo)
            {
                Console.WriteLine($"Impossível realizar a compra, seu saldo é menor que o valor da compra.");
            }
            else if (this.Valor < this.Saldo)
            {
                Console.WriteLine($"Valor da compra: {this.Valor}");
                Console.WriteLine($"Saldo do cartão: {this.Saldo}");
                Console.WriteLine($"Compra sendo processada");
            }
        }
    
    }
}