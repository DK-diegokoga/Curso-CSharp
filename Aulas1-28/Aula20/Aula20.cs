using System;
class Aula20{
    static void Main(){
        int[] vetor = new int[10];

        int i = 0;
        while(i < vetor.Length){
            vetor[i] = i + 1;
            i++;
        }
        for(int a = 0;a < vetor.Length;a++){
            Console.WriteLine("O valor do indice {0} é {1}", a,vetor[a]);
        }
        Console.WriteLine("Fim do loop");
    }
}