using System;
class Aula17{
    static void Main(){
        //Arrays unidimensionais -> Vetores
        //int n1,n2,n3,n4,n5;
        int[] vetor = new int[5];
        vetor[0] = 111;
        vetor[1] = 222;
        vetor[2] = 333;
        vetor[3] = 444;
        vetor[4] = 555;

        int[] outra_forma_de_vetor = new int[3]{55,77,99};
        int[] outra_forma_de_vetor = {55,77,99};
        string[] veiculos = new string[3];

        veiculos[0] = "Carro";
        veiculos[1] = "Avião";
        veiculos[2] = "Moto";

        for(int i = 0;i < 5; i++){
            Console.WriteLine("Valor do vetor de indice {0} é {1}",i,vetor[i]);            
        }
    }
}