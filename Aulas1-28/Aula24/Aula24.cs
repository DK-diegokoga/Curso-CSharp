using System;
class Aula24{
    static void Main(){
        Console.WriteLine("Chamando metodo");    
        int v1,v2;
        v1 = int.Parse(Console.ReadLine());
        v2 = int.Parse(Console.ReadLine());          
        metodo();
        soma(v1,v2);
    }

    static void metodo(){
        Console.WriteLine("Mensagem do metodo");
    }

    static int soma(int n1,int n2){
        int resultado = n1 + n2; 
        Console.WriteLine("A soma de {0} e {1} é {2}",n1,n2,resultado);     
        return resultado;   
    }
}