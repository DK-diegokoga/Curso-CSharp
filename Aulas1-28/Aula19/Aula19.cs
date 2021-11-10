using System;
class Aula19{
    static void Main(){
        int [] vetor = new int [10];
        for(int num = 0;num < 10;num++){
            Console.WriteLine("CFB Curso {0}",num);
        }
        for(int i = 0;i < vetor.Length;i++){
            vetor[i] = i + 1;
        }
        for(int i = 0;i < vetor.Length;i++){
            Console.WriteLine("O valor do indice {0} é {1}",i,vetor[i]);
        }
    }
}