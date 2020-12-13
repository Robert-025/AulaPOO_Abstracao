using System;

namespace AulaPOO_Abstracao.Classes
{
    public class Boleto : Pagamento
    {
        private int codigoDeBarras;
        public int CodigoDeBarras
        {
            get{ return codigoDeBarras; }
        }


        public void Registrar()
        {
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public void GerarBoleto( float valorDaComrpra)
        {
            float valorTotal = this.Valor - (this.Valor * 0.12f); 

            Console.WriteLine($"\nVocê tem 12% de desconto");
            Console.WriteLine($"\nValor do boleto: R${valorTotal}");
            Console.WriteLine($"Data: {this.Data}");
            Console.WriteLine($"Data de vencimento: {this.Data.AddDays(10)}");
            Console.WriteLine($"Código de barras: {this.CodigoDeBarras}");
            
        }
    }
}