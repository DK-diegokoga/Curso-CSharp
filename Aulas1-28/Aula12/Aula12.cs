using System;
class Aula11{
    static void Main(){
        int nota1,nota2,nota3,nota4;
        nota1=nota2=nota3=nota4=0;
        String resultado = "Reprovado";

        Console.WriteLine("Insira a nota: ");
        nota1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota4 = int.Parse(Console.ReadLine());
            
        int notaFinal = nota1 + nota2 + nota3 + nota4;

        if(notaFinal >= 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0}\nResultado: {1}",notaFinal, resultado);
        
        
        //OPERADORES
        //> Maior 
        //< Menor
        //>= Maior Igual
        //<= Menor Igual
        //== Igual
        //!= Diferente
    }
}