using System;
class Aula18{
    static void Main(){
        int[,] matriz = new int[3,5];
        int[,] matriz2 = new int[2,2]{{10,20},{30,40}};
        int[,] matriz3 = {{10,20,30,40,50},{60,70,80,90,100},{110,120,130,140,150}};
        /*
                     Colunas
        linhas : 10  20  30  40  50
        linhas : 60  70  80  90  100
        linhas : 110 120 130 140 150
        */
        //Primeira LINHA
        matriz[0,0] = 10;
        matriz[0,1] = 20;
        matriz[0,2] = 30;
        matriz[0,3] = 40;
        matriz[0,4] = 50; 
        //Segunda LINHA
        matriz[1,0] = 60;
        matriz[1,1] = 70;
        matriz[1,2] = 80;
        matriz[1,3] = 90;
        matriz[1,4] = 100;
        //Terceira LINHA
        matriz[2,0] = 110;
        matriz[2,1] = 120;
        matriz[2,2] = 130;
        matriz[2,3] = 140;
        matriz[2,4] = 150;       

        for(int linha = 0; linha < 3; linha++){
            for(int coluna = 0; coluna < 5; coluna++){
                Console.WriteLine("Valor da matriz na linha {0} é {1}",linha,matriz[linha,coluna]);
            }
        }
    }
}