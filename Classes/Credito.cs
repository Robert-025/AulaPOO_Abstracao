using System;

namespace AulaPOO_Abstracao.Classes
{
    public class Credito : Cartao 
    {
        private float limite = 3000;
        public float Limite{
            get{ return limite; }
        }


        public int parcelas;


        public void MostrarCartao()
        {

            Console.WriteLine($"\nLimite do cartão: R${this.Limite}");
            Console.WriteLine($"Bandeira do Cartão: {this.bandeira}");
            Console.WriteLine($"Número do cartão: {this.numero}");
            Console.WriteLine($"CVV do cartão: {this.cvv}");
            Console.WriteLine($"Nome do titular: {this.titular}");            
        }


        public void Pagar(float valor)
        {
            float valorTotal; 
            float valorParcela;
            
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                if (this.parcelas > 0 && this.parcelas < 7)
                {
                    valorTotal = this.Valor + (this.Valor * 0.05f);
                    valorParcela = valorTotal / this.parcelas;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"\nVocê pagará 5% de juros.");
                    Console.WriteLine($"Sua compra ficou num total de: R${valorTotal}");
                    Console.WriteLine($"Numa divisão de {this.parcelas}x de R${valorParcela} ");

                    Console.ResetColor();
                    
                }
                else if (this.parcelas > 6 && this.parcelas <= 12)
                {
                    valorTotal = this.Valor - (this.Valor * 0.08f);
                    valorParcela = this.Valor / this.parcelas;
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"\nVocê pagará 8% de juros.");
                    Console.WriteLine($"Sua compra ficou num total de: R${valorTotal}");
                    Console.WriteLine($"Numa divisão de: {this.parcelas}x de: R${valorParcela} ");

                    Console.ResetColor();
 
                }
                
                else if (this.parcelas > 12 || this.parcelas < 1)
                {
                    Console.WriteLine($"Digite um número parcelas válido");
                    
                    Console.ResetColor();
                    break;
                }   

            } while (this.parcelas > 12 || this.parcelas < 1);

        }
    }
}