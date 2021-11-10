using System;
class Aula21{
    static void Main(){
        string senha="123";
        string senha_user;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senha_user = Console.ReadLine();
            tentativas++;
        }while(senha_user != senha);        
        
        Console.WriteLine("Senha Correta numero de tentativas {0}",tentativas);
        
    
/*        
        int num = 5;
        while(num < 5){
            Console.WriteLine("While");
        }

        do{ 
            Console.WriteLine("Do While");            
        }while(num < 5);*/
    }
}