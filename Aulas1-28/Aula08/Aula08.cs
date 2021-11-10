using System;
class Aula08{
    static void Main(){
        int v1,v2,soma;
        string nome;

        Console.Write("Digite seu nome: " );
        nome = Console.ReadLine();
        Console.WriteLine("nome digitado: {0}",nome);

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor digitado: {0}",v1);

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor digitado: {0}",v2);            

        soma = v1+v2;
        Console.WriteLine("A soma dos valores é: {2}",v1,v2,soma);
    }
}