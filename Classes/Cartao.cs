using System;

namespace AulaPOO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;


        public string SalvarCartao()
        {
            Console.WriteLine($"Bandeira do cartão: {this.bandeira}");
            Console.WriteLine($"Número do cartão: {this.numero}");
            Console.WriteLine($"Nome do titular: {this.titular}");
            Console.WriteLine($"CVV do cartão: {this.cvv}");
            
            return "";
        }
    }
}