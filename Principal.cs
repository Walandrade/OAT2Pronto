using OATs.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3.cs
{
    internal class Principal
    {
        public static void Main(String[] args)
        {
            int opcao;

            Console.WriteLine("===========================================================================================");
            Console.WriteLine("|1 - ler os valores A, B, C e imprima na tela a soma                                        |");
            Console.WriteLine("|2 - Estado civil                                                                           |");
            Console.WriteLine("|3 - É  par ou ímpar.                                                                       |");
            Console.WriteLine("|4 - Se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.|");
            Console.WriteLine("|5 - Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo|");
            Console.WriteLine("|6 - Valores VERDADEIROS ou FALSOS.                                                         |");
            Console.WriteLine("|7 - Some 5, caso seja par ou some 8, caso seja ímpar                                       |");
            Console.WriteLine("|8 -  valores inteiros e diferentes e mostre-os em ordem decrescente.                       |");
            Console.WriteLine("|9 - Calculo do peso ideal                                                                  |");
            Console.WriteLine("|10 - Calculo do IMC – Índice de Massa Corporal                                             |");
            Console.WriteLine("|11 - Condições de pagamento                                                                |");
            Console.WriteLine("|12 - Notas do aluno                                                                        |");
            Console.WriteLine("|Escolha uma opcao:                                                                         |");
            Console.WriteLine("===========================================================================================");
            opcao= int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    AtividadeOAT2 exercicio1 = new AtividadeOAT2();

                    exercicio1.Atividade1();


                    break;
                case 2:
                    AtividadeOAT2 exercicio2 = new AtividadeOAT2();
                         exercicio2.Atividade2();


                    break;
                case 3:
                    AtividadeOAT2 exercicio3 = new AtividadeOAT2();

                    exercicio3.Atividade1();


                    break;
                case 4:
                    AtividadeOAT2 exercicio4 = new AtividadeOAT2();

                    exercicio4.Atividade1();


                    break;
                case 5:
                    AtividadeOAT2 exercicio5 = new AtividadeOAT2();

                    exercicio5.Atividade1();


                    break;
                case 6:
                    AtividadeOAT2 exercicio6 = new AtividadeOAT2();

                    exercicio6.Atividade1();


                    break;
                case 7:
                    AtividadeOAT2 exercicio7 = new AtividadeOAT2();

                    exercicio7.Atividade1();


                    break;
                case 8:
                    AtividadeOAT2 exercicio8 = new AtividadeOAT2();

                    exercicio8.Atividade1();

                    break;
                case 9:
                    AtividadeOAT2 exercicio9 = new AtividadeOAT2();

                    exercicio9.Atividade1();


                    break;
                case 10:
                    AtividadeOAT2 exercicio10 = new AtividadeOAT2();

                    exercicio10.Atividade1();


                    break;
                case 11:
                    AtividadeOAT2 exercicio11 = new AtividadeOAT2();

                    exercicio11.Atividade1();

                    break;
                case 12:
                    AtividadeOAT2 exercicio12 = new AtividadeOAT2();

                    exercicio12.Atividade1();


                    break;

                default:
                    Console.WriteLine("Opção Invalida!");
                    break;



            }

        }
    }
}
