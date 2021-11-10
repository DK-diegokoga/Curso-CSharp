using System;
class Aula11{
    static void Main(){
        int nota1,nota2,nota3,nota4;
        nota1=nota2=nota3=nota4=0;
        String resultado;

        Console.WriteLine("Insira a nota: ");
        nota1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Insira a nota: ");
        nota4 = int.Parse(Console.ReadLine());
            
        int notaFinal = nota1 + nota2 + nota3 + nota4;

        // Aprovado >= 60
        // Recuperação 59 & 40
        // Reprovado < 40
        if(notaFinal < 40){
            resultado = "Reprovado";
        }else if(notaFinal < 60 ){
            resultado = "Recuperação";
        }else{
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0}\nResultado: {1}",notaFinal, resultado);
    
    }
}