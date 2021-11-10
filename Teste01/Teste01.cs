using System;
class Program{
    static void Main(){
        string login = "";
        string senha = "";
        
        Console.Write("Digite seu Login: ");
        login = Console.ReadLine();
        
        Console.Write("Digite sua senha: ");
        senha = Console.ReadLine();

        if(validaLogin(login,senha).Equals(true)){
          Menu();
        }else{
          Main();
        }
    }
    

    static Boolean validaLogin(string login,string senha){
        if(login == "" | senha == ""){
            Console.WriteLine("Login ou senha não podem ser vazio\n");
            return false;
        }else{
            if(login.Contains("Diego") & senha.Contains("1111")){
                Console.WriteLine("Usuario Logado com sucesso");
                return true;
            }else{
                Console.WriteLine("Usuario não tem acesso\n");
            }return false;
        }
    }

    static void Menu(){
        int escolha = 0;
        while(escolha != 3){
            Console.WriteLine("Menu\n" + 
                            "1 - Soma simples\n" + 
                            "2 - Surpresa\n"+ 
                            "3 - Sair\n");
            Console.Write("Escolha o que deseja fazer: ");
            escolha = int.Parse(Console.ReadLine());
            switch(escolha){
                case 1:
                    Calculadora();
                break;
                case 2:
                    Console.WriteLine("Tem nada aqui não!");
                break;
                case 3:
                    Console.WriteLine("Fechando o programa");
                    Console.Clear();
                break;
                default:
                    Console.WriteLine("Tipo de operação Invalida\n");
                break;
            }
        }
    }

    static void Calculadora(){
        int v1,v2,resultado;
        string opcao = "";

        Console.WriteLine("Calculadora simples");
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor digitado:{0}",v1);

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor digitado:{0}",v2);            
        while(opcao!= "sair"){        
            Console.Write("a - Adição\n" +
                        "s - Subtração\n" + 
                        "m - Multiplicação\n" +
                        "d - Divisão\n" + 
                        "sair - Sair do programa\n" +
                        "Escoha a operação que deseja realizar: " );
            opcao = Console.ReadLine();
        
            switch(opcao){
                case "a":
                    resultado = v1 + v2;
                    Console.WriteLine("A soma de {0} + {1} é:{2}", v1,v2,resultado);
                break;
                case "s":
                    resultado = v1 - v2;
                    Console.WriteLine("A subtração de {0} - {1} é:{2}", v1,v2,resultado);
                break;
                case "m":
                    resultado = v1 * v2;
                    Console.WriteLine("A multiplicação de {0} * {1} é:{2}", v1,v2,resultado);
                break;
                case "d":
                    resultado = v1 / v2;
                    Console.WriteLine("A divisão de {0} / {1} é:{2}", v1,v2,resultado);
                break;      
                case "sair":
                    Console.WriteLine("Retornado para o menu");
                    Console.Clear();
                    Menu();
                break;
                default:
                    Console.WriteLine("Tipo de operação Invalida\n");
                break;    
            }
        }
    }
}