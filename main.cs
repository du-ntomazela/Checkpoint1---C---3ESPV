

string MenuSelecionado;
int MenuSelecionadoInt;
string[] Opcoes = { "Adicao", "Subtracao", "Multiplicacao", "Divisao", "Sair" };
string Num1;
string Num2;


float Num1Numeric;
float Num2Numeric;


Console.Write("\n------------- CALCULADORA ----------- \n");


do
{
    Console.Write("\n------------- MENU ----------- \n");
    for (int Opco = 0; Opco < Opcoes.Length; Opco++)
    {
        Console.WriteLine($"{Opco + 1} - {Opcoes[Opco]}");
    }
    Console.Write("Selecione uma das opções \n -->");
    MenuSelecionado = Console.ReadLine();
    if (int.TryParse(MenuSelecionado, out MenuSelecionadoInt))
    {
        if ((MenuSelecionadoInt > 0) & (MenuSelecionadoInt <= Opcoes.Length)) {
            if (MenuSelecionadoInt != (Opcoes.Length)) {
                Console.Write("Digite o primeiro numero \n -->");
                Num1 = Console.ReadLine();
                Console.Write("Digite o segundo numero \n -->");
                Num2 = Console.ReadLine();
                if ((float.TryParse(Num1, out Num1Numeric) & (float.TryParse(Num2, out Num2Numeric)))) {
                    switch (MenuSelecionadoInt)
                    {
                        case 1:
                            Console.Write($"O resultado da Soma {Num1Numeric} + {Num2Numeric} é igual a {Num1Numeric + Num2Numeric}");
                            break;

                        case 2:
                            Console.Write($"O resultado da Subtração {Num1Numeric} - {Num2Numeric} é igual a {Num1Numeric - Num2Numeric}");
                            break;

                        case 3:
                            Console.Write($"O resultado da Multiplicação {Num1Numeric} X {Num2Numeric} é igual a {Num1Numeric * Num2Numeric}");
                            break;

                        case 4:
                            if (Num2Numeric == 0)
                            {
                                Console.WriteLine("Não é possivel realizar divisões por 0! por favor informe o segundo numero sendo diferente de 0!");
                                    }
                            else
                            {
                                Console.Write($"O resultado da Divisão {Num1Numeric} / {Num2Numeric} é igual a {Num1Numeric / Num2Numeric}");

                            }
                            break;

                    } 
                }
                else
                {
                    Console.WriteLine("Ambos os valores digitados devem ser numeros (em caso de decimais utilizar o marcador de casa decimal '.')");
                }

            }
            else
            {
                Console.WriteLine("Saindo da calculadora");
            }
        }
        else
        {
            Console.WriteLine($"Digite um id entre 1 e {Opcoes.Length}!");
        }
    }
    else
    {
        Console.WriteLine("Para acessar uma das funcionalidades é necessário digitar o ID referente ao módulo.");
    }

} while (MenuSelecionadoInt != 5);
