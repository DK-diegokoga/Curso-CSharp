using System;
class Aula25{
    static void Main(){
        int numero = 10;
        dobrarValor(ref numero);
        Console.WriteLine("O dobro do valor é {0}",numero);
    }
    static void dobrarValor_com_referencia(ref int valor){
        valor *= 2;
    }

    static void dobrarValor_sem_referencia(int valor){
        valor *= 2;
    }
}