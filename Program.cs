using System;
using AulaPOO_Abstracao.Classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoCartao;
            int opcaoPagamento;

                Console.Clear();

                    Console.WriteLine($"Digite o valor da sua compra: ");
                    float valorDaCompra = float.Parse( Console.ReadLine() );

                    Console.WriteLine($"\nSelecione uma forma de pagamento: ");
                    Console.WriteLine($"[1] Boleto"); 
                    Console.WriteLine($"[2] Cartão");
                    opcaoPagamento = int.Parse( Console.ReadLine() );

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
                        do
                        {
                            
                            Console.WriteLine($"\nSelecione qual o tipo de cartão:");
                            Console.WriteLine($"[1] Crédito"); 
                            Console.WriteLine($"[2] Débito");
                            opcaoCartao = int.Parse( Console.ReadLine() );

                            switch (opcaoCartao)
                            {
                                case 1:
                                //Crédito
                                    Credito credito = new Credito();

                                    credito.Valor = valorDaCompra;

                                    if (valorDaCompra < credito.Limite)
                                    {
                                        Console.WriteLine($"\nDigite a bandeira do cartão: ");
                                        credito.bandeira = Console.ReadLine();

                                        Console.WriteLine($"\nDigite o número do cartão: ");
                                        credito.numero = Console.ReadLine();
                                        
                                        Console.WriteLine($"\nDigite o nome do titular: ");
                                        credito.titular = Console.ReadLine();
                                        
                                        Console.WriteLine($"\nDigite o CVV do cartão: ");
                                        credito.cvv = Console.ReadLine();

                                        do
                                        {
                                            Console.WriteLine($"\nDigite o número de parcelas, sendo o máximo 12x e o mínimo 1x");
                                            credito.parcelas = int.Parse( Console.ReadLine() );

                                            if (credito.parcelas <= 12 || credito.parcelas >= 1)
                                            {
                                            credito.MostrarCartao();

                                            credito.Pagar(valorDaCompra);   
                                            }

                                        } while (credito.parcelas > 12 || credito.parcelas < 1);
                                            
                                    }
                                    if (valorDaCompra > credito.Limite)
                                    {
                                        Console.WriteLine($"\nLimite do cartão excedido");
                                    }

                                    break;

                                case 2: 
                                //Débito
                                    Debito debito = new Debito();

                                    debito.Valor = valorDaCompra;

                                    if (debito.Saldo >= valorDaCompra)
                                    {   
                                        Console.WriteLine($"\nDigite a bandeira do cartão: ");
                                        debito.bandeira = Console.ReadLine();
                                            
                                        Console.WriteLine($"\nDigite o número do cartão: ");
                                        debito.numero = Console.ReadLine();
                                            
                                        Console.WriteLine($"\nDigite o nome do titular: ");
                                        debito.titular = Console.ReadLine();

                                        debito.MostrarCartao();

                                        System.Threading.Thread.Sleep(2000);

                                        debito.Pagar(valorDaCompra);
                                    }
                                    if (debito.Saldo < valorDaCompra)
                                    {
                                        Console.WriteLine($"\nSaldo não disponível para compra");
                                    }

                                  break;

                                default: Console.WriteLine($"\nDigite uma opção válida!");
                                    break;
                            }
                        } while (opcaoCartao != 1 && opcaoCartao != 2);
                            
                        break; 

                        default: Console.WriteLine($"\nFim do programa. Digite uma opção válida!");
                            break;

            }
        }
    }
}
