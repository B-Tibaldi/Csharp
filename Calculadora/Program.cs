using System;

public class Calculadora {
    static void Main () {
        int n1, n2;
        string entrada;
        char escolha;

        Console.Write("============\nCALCULADORA\n============\n");
        Console.WriteLine("Indique 2 numeros:\n");

        if (int.TryParse(Console.ReadLine(), out n1) && int.TryParse(Console.ReadLine(), out n2)) {
            
            Console.Write("Escolha uma das opcoes abaixo:\n");
            Console.Write("a)Adicao\nb)Subtracao\nc)Multiplicacao\nd)Divisao\n");
            entrada = Console.ReadLine()!;
            if(char.TryParse(entrada, out escolha)) {
                escolha = entrada[0]; //Seleciona o primeiro caracter da palavra
                switch(escolha) {
                    case 'a':
                        Console.Write($"{n1+n2}\n");
                        break;

                    case 'b':
                        Console.Write($"{n1-n2}\n");
                        break;

                    case 'c':
                        Console.Write($"{n1*n2}\n");
                        break;

                    case 'd':
                        if (n2 == 0)
                            Console.WriteLine("Erro! Divisao por 0\n"); 
                        else
                            Console.Write($"{n1/n2}\n");
                        break;

                    default:
                        Console.Write("Erro! Opcao Invalida\n");
                        break;

                }

            }
            else {
                Console.WriteLine("Erro! Entrada invalida\n");
            }
        }

        else {
            Console.WriteLine("Erro! Valor invalido\n");
        }
    }
}