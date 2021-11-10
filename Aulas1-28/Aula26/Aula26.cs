using System;
class Aula26{
    static void Main(){
        int dividendo, divisor,quociente,resto;
        dividendo = 10;
        divisor = 5;
        quociente = divide(dividendo,divisor,out resto);
        Console.WriteLine("{0}/{1} é {2} e o resto é {3}",dividendo,divisor,quociente,resto);
    }
    static int divide(int dividendo,int divisor,out int resto){
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}