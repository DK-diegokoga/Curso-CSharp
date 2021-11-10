using System;
class Aula16{
    static void Main(){
        int tempo = 0;
        char escolha;

        inicio:

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("a - Avião |"  + 
                        "c - Carro |"  +
                        "o - Ônibus" +
                        "\nEscolha o transporte: ");
        escolha = char.Parse(Console.ReadLine());
        switch(escolha){
            case 'a':
            case 'A':           
                tempo = 50;
            break;
            case 'c':
            case 'C':            
                tempo = 480;
            break;
            case 'o':
            case 'O':
                tempo = 660;
            break;      
            default:
                tempo = -1;
            break;    
        }

        if(tempo<0){
            Console.WriteLine("Transporte indisponivel");
        }else{
        Console.WriteLine("Tempo para o transporte escolhido em minutos é:{0}",tempo);
        }
        Console.WriteLine("Calcular um novo transporte?[s/n]");

        escolha =char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}