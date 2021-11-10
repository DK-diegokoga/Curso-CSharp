using System;
class Aula10{
    enum dias_da_Semana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
    static void Main(){
 
        int dias = (int)dias_da_Semana.Segunda;
 
        Console.WriteLine("O dia da semana é: {0}",dias);
    }
}