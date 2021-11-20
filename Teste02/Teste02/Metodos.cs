using System;


namespace Teste02
{
    class Metodos
    {

        public Boolean Login()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("\tLOGIN DO SISTEMA");
            Console.WriteLine("---------------------");
        entrada:
            Console.WriteLine("Insira seu nome:");
            string login = Console.ReadLine();
            Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();

            if (login == "" | senha == "")
            {
                Console.WriteLine("Login ou senha não podem ser vazio\n");
                goto entrada;
            }
            else
            {
                if (login.Contains("Diego") & senha.Contains("1111"))
                {
                    Console.WriteLine("Usuario Logado com sucesso");
                    return true;
                }
                else
                {
                    Console.WriteLine("Usuario não tem acesso\n");
                }
                return false;
            }
        }


        public void Menu()
        {
            Calculadora calc = new Calculadora();
            int escolha = 0;
            while (escolha != 3)
            {
                menu:
                Console.WriteLine("Menu\n" +
                                "1 - Soma simples\n" +
                                "2 - Surpresa\n" +
                                "3 - Sair\n");
                Console.Write("Escolha o que deseja fazer: ");
                try
                {
                    escolha = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Clear();
                    goto menu;
                }
                
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        calc.Calcular();
                        break;
                    case 2:
                        Console.WriteLine("Tem nada aqui não!");
                        goto menu;
                    case 3:
                        Console.WriteLine("Fechando o programa");
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Tipo de operação Invalida\n");
                        Console.Clear();
                        break;
                }
            }
        }

        public void Incrementa()
        {
            Console.WriteLine();
            int quantidade;

            Console.WriteLine("Insira a quantidade de vezes que vai ser incrementado");
            quantidade = (int)Convert.ToInt32(Console.ReadLine());

            int incremento = 0;
            for (int i = 0; i < quantidade; i++)
            {
                incremento++;
            }
            Console.WriteLine($"Incremento: {incremento}");
        }

        public void Tratamento()
        {
            int valor;
            int i = 0;

            Console.WriteLine("--------------------------");
            Console.WriteLine("\tTratamento de Exception");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Insira um valor para ser dividido");
            valor = (int)Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(valor / i);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }     
    }
}