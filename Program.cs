using System;
using AulaPOO_Abstracao.Classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite o valor da sua compra: ");
            float valorDaCompra = float.Parse( Console.ReadLine() );

            Console.WriteLine($"Selecione uma forma de pagamento: \n");
            Console.WriteLine($"[1] Boleto"); 
            Console.WriteLine($"[2] Cartão");
            int opcaoPagamento = int.Parse( Console.ReadLine() );

            switch (opcaoPagamento)
            {
                case 1:
                //Boleto
                    Boleto boleto = new Boleto();

                    boleto.Registrar();
                    boleto.Valor = valorDaCompra;
                    boleto.Data = DateTime.Now;

                    boleto.GerarBoleto(valorDaCompra);

                  break;

                case 2: 
                //Cartão
                    Console.WriteLine($"Selecione qual o tipo de cartão:");
                    Console.WriteLine($"[1] Crédito"); 
                    Console.WriteLine($"[2] Débito");
                    int opcaoCartao = int.Parse( Console.ReadLine() );

                    switch (opcaoCartao)
                    {
                        case 1:
                        //Crédito
                            Credito credito = new Credito();

                            Console.WriteLine($"Digite o número de parcelas, sendo o máximo 12x");
                            int parcelas = int.Parse( Console.ReadLine() );

                            Console.WriteLine($"Digite a bandeira do cartão: ");
                            credito.bandeira = Console.ReadLine();

                            Console.WriteLine($"Digite o número do cartão: ");
                            credito.numero = Console.ReadLine();
                            
                            Console.WriteLine($"Digite o nome do titular: ");
                            credito.titular = Console.ReadLine();
                            
                            
                            
                            
                            
                                
                          break;

                        default:
                            break;
                    }
                    

                    
                  break;

                default:
                    break;
            }
            
            
            
            
        }
    }
}
