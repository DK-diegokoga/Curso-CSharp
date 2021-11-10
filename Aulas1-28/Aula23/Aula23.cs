using System;
class Aula23{
        static int[] vetor1 = new int[5];
        static int[] vetor2 = new int[5];
        static int[] vetor3 = new int[5];
        static int[,] matriz = new int[2,5];
    static void Main(){
        int opc;
        Console.WriteLine("Escolha uma opção:\n" +
                        "1 - BinarySearch\n" +
                        "2 - Copy\n" +
                        "3 - CopyTo\n"+
                        "4 - GetLowerBound\n" +
                        "5 - GetUpperBound\n" +
                        "6 - GetLongLength" +
                        "7 - GetValue\n" +
                        "8 - IndexOf\n" +
                        "9 - LastIndexOf\n"+
                        "10 - Reverse\n" +
                        "11 - SetValue\n" +
                        "12 - Sort"                        
                        );
        opc = int.Parse(Console.ReadLine());
        switch(opc){
            case 1:
                BinarySearch();         
            break;
            case 2:
                Copy();
            break;
            case 3:
                Copyto();
            break;
            case 4:
                GetLowerBound();
            break;
            case 5:
                GetUpperBound();
            break;
            case 6:
                GetLongLenght();
            break;   
            case 7:
                GetValue();
            break; 
            case 8:
                IndexOf();
            break; 
            case 9:
                LastIndexOf();
            break; 
            case 10:
                Reverse();
            break; 
            case 11:
                SetValue();
            break;           
            case 12:
                Sort();
            break;                 
            default:
                Console.WriteLine("Opção invalida");
            break;
        }
        
   }
    static void insereValor(){
        matriz[0,0] = 11; 
        matriz[0,1] = 22; 
        matriz[0,2] = 00; 
        matriz[0,3] = 44; 
        matriz[0,4] = 55; 

        matriz[1,0] = 66;
        matriz[1,1] = 77;
        matriz[1,2] = 88;
        matriz[1,3] = 99;
        matriz[1,4] = 00;
        
	    Random random =  new Random();
	    for(int i = 0; i < vetor1.Length;i++){
	        vetor1[i] = random.Next(1,50);
	    }    

        Console.WriteLine("Elementos do vetor1");
        foreach(int ler_valor in vetor1){
            Console.WriteLine("Valores {0}",ler_valor);
        }    

    }
    static void BinarySearch(){
        insereValor();
        Console.WriteLine("Metodo BinarySearch");
        int item_procurado = 33;
        int indice = Array.BinarySearch(vetor1,item_procurado);
        Console.WriteLine("Valor {0} está na posição {1}",item_procurado,indice);
        Main();   
    }

    static void Copy(){
        insereValor();
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int ler_vetor in vetor2){
            Console.WriteLine("Os valores {0}",ler_vetor);
        }
        Main();        
    }

    static void Copyto(){
        insereValor();
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int ler_vetor in vetor3){
            Console.WriteLine("Os valores {0}",ler_vetor);
        }
        Main();
    }    
    
    static void GetLowerBound(){
        insereValor();
        Console.WriteLine("GetLowerBound");
        int menor_indice_do_Vetor = vetor1.GetLowerBound(0);
        int menor_indice_da_Matriz = matriz.GetLowerBound(1);
        Console.WriteLine("O menor índice do vetor {0}",menor_indice_do_Vetor);
        Console.WriteLine("O menor índice da matriz {0}", menor_indice_da_Matriz);
        Main();
    }

    static void GetUpperBound(){
        insereValor();
        Console.WriteLine("GetUpperBound");
        int maior_indice_do_Vetor = vetor1.GetUpperBound(0);
        int maior_indice_da_Matriz = matriz.GetUpperBound(1);
        Console.WriteLine("O menor índice do vetor {0}",maior_indice_do_Vetor);
        Console.WriteLine("O menor índice da matriz {0}", maior_indice_da_Matriz);
        Main();        
    }

    static void GetLongLenght(){
        insereValor();
        Console.WriteLine("GetLongLength");
        long quantidade_de_elementos_no_Vetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos no vetor {0}", quantidade_de_elementos_no_Vetor);
        Main();
    }

    static void GetValue(){
        insereValor();
        Console.WriteLine("GetValue");
        int valor_do_vetor = Convert.ToInt32(vetor1.GetValue(3));
        int valor_da_matriz = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor que esta no indice do vetor {0}", valor_do_vetor);
        Console.WriteLine("Valor que esta no indice da matriz {0}", valor_da_matriz);
        Main();
    }

    static void IndexOf(){
        insereValor();
        Console.WriteLine("IndexOf");
        int primeiro_encontrado = Array.IndexOf(vetor1,3);
        Console.WriteLine("Primeira posição encontrada do vetor {0}", primeiro_encontrado);
        Main();        
    }
    static void LastIndexOf(){
        insereValor();
        Console.WriteLine("LastIndexOf");
        int ultimo_encontrado = Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Ultima posição encontrada do vetor {0}", ultimo_encontrado);
        Main();        
    }

    static void Reverse(){
        insereValor();
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int vetor_reverso in vetor1){
            Console.WriteLine("Valores reversos {0}", vetor_reverso);
        }
        Main();         
    }

    static void SetValue(){
        insereValor();
        vetor2.SetValue(99,0);
        for(int i = 0 ; i < vetor2.Length; i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("SetValue");
        foreach(int i in vetor2){
            Console.WriteLine("Valores setados no vetor 2 {0}", i);
        }
        Main();
    }

    static void Sort(){
        insereValor();
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Sort");
        Console.WriteLine("Vetor 1\n");
        foreach(int i in vetor1){
            Console.WriteLine("Vetor 1 ordenado {0}", i);      
        }
        Console.WriteLine("Vetor 2\n");
        foreach(int i in vetor2){
            Console.WriteLine("Vetor 2 ordenado {0}", i);      
        }
        Console.WriteLine("Vetor 3\n");
        foreach(int i in vetor3){
            Console.WriteLine("Vetor 3 ordenado {0}", i);      
        }      
        Main();          
    }
}