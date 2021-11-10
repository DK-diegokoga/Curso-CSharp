using System;
class Aula05{
    static void Main(){

        var login = "Diego";
        var senha = 123456;

        bool validar_certo_login = (login == "Diego") & (senha == 123456);
        bool validar_errado_login = (login == "Gustavo") & (senha == 654321);

        if(validar_certo_login == true){
            Console.WriteLine("Tudo certo entrando no sistema...");
            Console.WriteLine("Validação: " + validar_certo_login);
            menu();
        }else{
            Console.WriteLine("Não entrou no sistema...");
            Console.WriteLine("Validação: " + validar_errado_login);            
        }
    }

    static void menu(){
        Console.WriteLine("1 - Lista de coisas\n" + "2 - Escolher algo\n");
    }
}