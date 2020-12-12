﻿using System;
using AulaPOO_Abstracao.Classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoCartao;
            int opcaoPagamento;


                    Console.WriteLine($"Digite o valor da sua compra: ");
                    float valorDaCompra = float.Parse( Console.ReadLine() );

                    Console.WriteLine($"Selecione uma forma de pagamento: \n");
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
                            
                            Console.WriteLine($"Selecione qual o tipo de cartão:");
                            Console.WriteLine($"[1] Crédito"); 
                            Console.WriteLine($"[2] Débito");
                            opcaoCartao = int.Parse( Console.ReadLine() );

                            switch (opcaoCartao)
                            {
                                case 1:
                                //Crédito
                                    Credito credito = new Credito();

                                    Console.WriteLine($"Digite a bandeira do cartão: ");
                                    credito.bandeira = Console.ReadLine();

                                    Console.WriteLine($"Digite o número do cartão: ");
                                    credito.numero = Console.ReadLine();
                                    
                                    Console.WriteLine($"Digite o nome do titular: ");
                                    credito.titular = Console.ReadLine();
                                    
                                    Console.WriteLine($"Digite o CVV do cartão: ");
                                    credito.cvv = Console.ReadLine();

                                    do
                                    {
                                        Console.WriteLine($"Digite o número de parcelas, sendo o máximo 12x");
                                        credito.parcelas = int.Parse( Console.ReadLine() );

                                        credito.Pagar(valorDaCompra);
                                    } while (credito.parcelas > 12);

                                    credito.Pagar(valorDaCompra);
                                        
                                  break;

                                case 2: 
                                //Débito
                                    Debito debito = new Debito();

                                    Console.WriteLine($"Digite a bandeira do cartão: ");
                                    debito.bandeira = Console.ReadLine();
                                        
                                    Console.WriteLine($"Digite o número do cartão: ");
                                    debito.numero = Console.ReadLine();
                                        
                                    Console.WriteLine($"Digite o nome do titular: ");
                                    debito.titular = Console.ReadLine();
                                    
                                    Console.WriteLine($"Digite o CVV do cartão: ");
                                    debito.cvv = Console.ReadLine();

                                    debito.Pagar(valorDaCompra);

                                  break;

                                default: Console.WriteLine($"Digite uma opção válida!");
                                    break;
                            }
                        } while (opcaoCartao != 1 && opcaoCartao != 2);
                            
                        break;

                        default: Console.WriteLine($"Fim do programa. Digite uma opção válida!");
                            break;

            }
        }
    }
}
