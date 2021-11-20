using System;

namespace Teste02
{
    class Calculadora
    {
        public void Calcular()
        {
            Metodos metodos = new Metodos();
            int v1, v2, resultado;
            string opcao = "";

            Console.WriteLine("Calculadora simples");
            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor digitado:{0}", v1);

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor digitado:{0}", v2);
            while (opcao != "sair")
            {
                escolha:
                Console.Write("a - Adição\n" +
                            "s - Subtração\n" +
                            "m - Multiplicação\n" +
                            "d - Divisão\n" +
                            "sair - Sair do programa\n" +
                            "Escoha a operação que deseja realizar: ");
                try
                {
                    opcao = Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Clear();
                    goto escolha;
                }
                

                switch (opcao)
                {
                    case "a":
                        resultado = v1 + v2;
                        Console.WriteLine("A soma de {0} + {1} é:{2}", v1, v2, resultado);
                        break;
                    case "s":
                        resultado = v1 - v2;
                        Console.WriteLine("A subtração de {0} - {1} é:{2}", v1, v2, resultado);
                        break;
                    case "m":
                        resultado = v1 * v2;
                        Console.WriteLine("A multiplicação de {0} * {1} é:{2}", v1, v2, resultado);
                        break;
                    case "d":
                        resultado = v1 / v2;
                        Console.WriteLine("A divisão de {0} / {1} é:{2}", v1, v2, resultado);
                        break;
                    case "sair":
                        Console.WriteLine("Retornado para o menu");
                        Console.Clear();
                        metodos.Menu();
                        break;
                    default:
                        Console.WriteLine("Tipo de operação Invalida\n");
                        break;
                }
            }

        }
    }
}