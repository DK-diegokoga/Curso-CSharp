using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mudando o texto!");
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
          
        }
    }
}
