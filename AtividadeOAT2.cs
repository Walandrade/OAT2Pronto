using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATs.cs
{
    internal class AtividadeOAT2
    {

        public void Atividade1()
        {
            Console.WriteLine(" Informe o valor de A:");
            int A =
            int.Parse(Console.ReadLine());
            Console.WriteLine(" Informe o valor de B:");
            int B =
            int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            int C =
            int.Parse(Console.ReadLine());
            int valor = A + B;
            Console.WriteLine(" O valor da soma de A e B é:" + valor);
            if (valor < C)
                Console.WriteLine(" o resultado da soma de A e B é menor que o valor de C!");
            else
                Console.WriteLine(" O resultado da soma de A e B é maior ou igual o valor de C!");
            Console.WriteLine();



        }
        public void Atividade2()
        {
            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.WriteLine();

            Console.WriteLine("Digite o seu nome:");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite seu sexo: (F ou M)");
            string sexo = Console.ReadLine();

            Console.WriteLine("Digite seu estado civil: (Solteira, Namorando, Noivo(a), Casado(a))");
            string estadoCivil = Console.ReadLine();

            if (sexo == "F" || sexo == "F" && estadoCivil == "Casada" || estadoCivil == "casada" || estadoCivil == "CASADA")
            {
                Console.WriteLine("Há quanto tempo você é casada?");
                int tempoCasada = int.Parse(Console.ReadLine());

                Console.WriteLine($"A usuária {nome} é do sexo {sexo}, e é {estadoCivil} há {tempoCasada}. ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"O usuário {nome} é do sexo {sexo} e é {estadoCivil}.");
                Console.ReadLine();
            }



        }
        public void Atividade3()
        {
            int num;

            Console.WriteLine("Insira um número:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} é um número par", num);
            }
            else
            {
                Console.WriteLine("{0} é um número ímpar!", num);
            }
            Console.ReadKey();




        }
        public void Atividade4()
        {
            int A;
            int B;
            int C;

            Console.WriteLine("Insira um número inteiro:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número inteiro:");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"O resultado é: {C}");
            }
            else
            {
                C = A * B;
                Console.WriteLine($"O resultado é: {C}");
            }

            Console.ReadKey();




        }
        public void Atividade5()
        {
            int num1;
            int resultado;

            Console.WriteLine("Insira um número negativo ou positivo:");
            num1 = int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                resultado = num1 * 2;
                Console.WriteLine($"O resultado é: {resultado}");
            }
            else
            {
                resultado = num1 * 3;
                Console.WriteLine($"O resultado é: {resultado}");
            }
            Console.ReadKey();




        }
        public void Atividade6()
        {
          
            
                Console.WriteLine("Digite o primeiro valor: ");
                int valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                int valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine("O primeiro valor é par? " + VerificarPar(valor1));
                Console.WriteLine("O segundo valor é par? " + VerificarPar(valor2));
            

            static int LerValor()
            {
                int valor;
                while (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Valor inválido. Digite novamente: ");
                }
                return valor;
            }

            static bool VerificarPar(int valor)
            {
                return valor % 2 == 0;
            }
        }



   
    public void Atividade7()
        {
            int num;

            Console.WriteLine("Insira um número:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                int Num1 = num + 5;
                Console.WriteLine($"O resultado da operação é: {num}");
                Console.WriteLine(Num1);
            }
            else
            {
                int Num1 = num + 8;
                Console.WriteLine($"O resultado da operação é: {num}");
                Console.WriteLine(Num1);
            }
            Console.ReadKey();






        }
        public void Atividade8()
        {
            int[] numeros = new int[3];

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Insira três números:");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números em ordem decrescente é:");
            Console.WriteLine("");
            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int numero in numeros)

            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();




        }
        public void Atividade9()
        {
            string sexo = string.Empty;
            decimal pesoIdeal = 0;

            do
            {

                Console.WriteLine("Digite o seu sexo, digite f para feminino e m para masculino:");
                sexo = Console.ReadLine().ToUpper();
                if (sexo != "F" && sexo != "M")
                    Console.WriteLine("Digite novamente:");

            } while (sexo != "F" && sexo != "M");

            if (sexo == "M")
            {
                Console.WriteLine("Digite a sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("72,7") * h) - 58;
            }

            if (sexo == "F")
            {
                Console.WriteLine("Digite a sua altura:");
                decimal h = decimal.Parse(Console.ReadLine());
                pesoIdeal = (decimal.Parse("62,1") * h) - decimal.Parse("44,7");
            }

            Console.WriteLine($"O peso ideal é: {pesoIdeal}");

            Console.ReadKey();



        }
        public void Atividade10()
        {
            string sexo = string.Empty;
            decimal imc = 0;
            decimal altura = 0;
            decimal peso = 0;
            Console.WriteLine("Índice de Massa Corporal");
            Console.WriteLine("");
            Console.WriteLine("Digite a sua altura:");
            altura = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu peso:");
            peso = decimal.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            if (imc < 18.5m)
            {
                Console.WriteLine($"Você está abaixo do IMC saudável, seu IMC é:{imc}  ");
            }
            else if (imc >= 18.5m && imc <= 25)
            {
                Console.WriteLine($"Você tem o IMC ideal e saudável, seu IMC é:{imc} ");
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine($"Seu IMC é de uma pessoa acima do peso, seuIMC é: {imc}");
            }
            else
            {
                Console.WriteLine($"Seu IMC é de uma pessoa obesa, seu IMC {imc} ");
            }
            Console.ReadKey();



        }
        public void Atividade11()
        {
            int escolha;
            double desconto = 0;
            double valor = 0;
            double acrescimo = 0;
            do
            {
                Console.WriteLine("Computador R$2000,00 | Opções de pagamento: ");
                Console.WriteLine(" ");
                Console.WriteLine("1. A vista no dinheiro ou cheque.");
                Console.WriteLine("2. À vista no cartão de crédito.");
                Console.WriteLine("3. Parcelado duas vezes sem juros.");
                Console.WriteLine("4. Parcelado quatro vezes com juros.");
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            valor = 10.0 / 100 * 2000; desconto = 2000 - valor;
                            Console.WriteLine($"O pagamento à vista no dinheiro ou chegue recebe 10 % de desconto(R${valor},00), o valor total fica R${desconto},00");
                            break;
                        case 2:
                            valor = 15.0 / 100 * 2000;
                            desconto = 2000 - valor;
                            Console.WriteLine($"O pagamento à vista no crédito recebe 15 % de desconto(R${valor},00), o valor total fica R${desconto},00");
                            break;
                        case 3:
                            int parcela = 2000 / 2;
                            Console.WriteLine($"O pagamento parcelado em duas vezes tem parcelas de R${parcela},00 cada.");
                            break;
                        case 4:
                            valor = ((10.0 / 100) * 2000) + 2000;
                            acrescimo = valor / 4;
                            Console.WriteLine($"O ´pagamento parcelado em quatro vezes tem acréscimo de 10 % de juros, total de R${valor},00, as parcelas ficam R${acrescimo},00 cada.");
                            break;
                        default:
                            Console.WriteLine("Opção incorreta, tente novamente!");
                            break;
                    }
                }
            } while (escolha != 4);
            Console.ReadLine();



        }
        public void Atividade12()
        {
            double ME;

            double MA;

            double SN2;

            double TN3;



            Console.WriteLine("Digite o seu código de identificação:");

            int COD =

            int.Parse(Console.ReadLine());



            Console.WriteLine();



            Console.WriteLine("Digite sua nota referente a primeira prova:");

            double PN =

            double.Parse(Console.ReadLine());

            while (PN < 0 && PN > 100)

            {

                Console.WriteLine("Nota Inválida, por favor corrija!");

                PN =

                double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Digite sua nota referente a segunda prova:");

            double SN =

            double.Parse(Console.ReadLine());

            while (SN < 0 && SN > 100)

            {

                Console.WriteLine("Nota Inválida, por favor corrija!");

                SN =

                double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Digite sua nota referente a terceira prova:");

            double TN =

            double.Parse(Console.ReadLine());

            while (TN < 0 && TN > 100)

            {

                Console.WriteLine("Nota Inválida, por favor corrija!");

                TN =

                double.Parse(Console.ReadLine());

            }





            ME = PN + SN + TN / 3;

            SN2 = Math.Pow(SN, 2);

            TN3 = Math.Pow(TN, 3);

            MA = (PN + SN2 + TN3 + ME) / 7;



            Console.WriteLine();



            if (MA >= 90)

            {

                Console.WriteLine($"Código do aluno: {COD}");

                Console.WriteLine($"Nota da primeira Prova: {PN}");

                Console.WriteLine($"Nota da segunda prova: {SN}");

                Console.WriteLine($"Nota da terceira prova: {TN}");

                Console.WriteLine($"Média dos exercícios: {ME}");

                Console.WriteLine($"Média de aproveitamento: {MA}");

                Console.WriteLine("Conceito corresponente: A");

                Console.WriteLine("Situação: APROVADO");

            }

            else if (MA < 90 && MA >= 75)

            {

                Console.WriteLine($"Código do aluno: {COD}");

                Console.WriteLine($"Nota da primeira Prova: {PN}");

                Console.WriteLine($"Nota da segunda prova: {SN}");

                Console.WriteLine($"Nota da terceira prova: {TN}");

                Console.WriteLine($"Média dos exercícios: {ME}");

                Console.WriteLine($"Média de aproveitamento: {MA}");

                Console.WriteLine("Conceito corresponente: B");

                Console.WriteLine("Situação: APROVADO");

            }

            else if (MA < 75 && MA >= 60)

            {

                Console.WriteLine($"Código do aluno: {COD}");

                Console.WriteLine($"Nota da primeira Prova: {PN}");

                Console.WriteLine($"Nota da segunda prova: {SN}");

                Console.WriteLine($"Nota da terceira prova: {TN}");

                Console.WriteLine($"Média dos exercícios: {ME}");

                Console.WriteLine($"Média de aproveitamento: {MA}");

                Console.WriteLine("Conceito corresponente: C");

                Console.WriteLine("Situação: APROVADO");

            }

            else if (MA < 60 && MA >= 40)

            {

                Console.WriteLine($"Código do aluno: {COD}");

                Console.WriteLine($"Nota da primeira Prova: {PN}");

                Console.WriteLine($"Nota da segunda prova: {SN}");

                Console.WriteLine($"Nota da terceira prova: {TN}");

                Console.WriteLine($"Média dos exercícios: {ME}");

                Console.WriteLine($"Média de aproveitamento: {MA}");

                Console.WriteLine("Conceito corresponente: D");

                Console.WriteLine("Situação: REPROVADO");

            }

            else

            {

                Console.WriteLine($"Código do aluno: {COD}");

                Console.WriteLine($"Nota da primeira Prova: {PN}");

                Console.WriteLine($"Nota da segunda prova: {SN}");

                Console.WriteLine($"Nota da terceira prova: {TN}");

                Console.WriteLine($"Média dos exercícios: {ME}");

                Console.WriteLine($"Média de aproveitamento: {MA}");

                Console.WriteLine("Conceito corresponente: E");

                Console.WriteLine("Situação: REPROVADO");

            }

            Console.ReadKey();





        }
    }
}
