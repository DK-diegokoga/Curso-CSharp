using System;
class Aula22{
    static void Main(){
        int[] vetor = new int[3];
        vetor[0] = 10;
        vetor[1] = 20;
        vetor[2] = 30;
/*
        for(int i = 0; i < vetor.Length;i++){
            Console.WriteLine("Valor do vetor no indice {0} é {1}",i,vetor[i]);
        }
*/
        foreach(int recebe_colecao in vetor){
            Console.WriteLine("Valor recebido da coleção {0}",recebe_colecao);
        }

    }
}