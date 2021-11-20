using System;


namespace Teste02
{
    class Program
    {
        static void Main()
        {
            Metodos metodos = new Metodos();
                if (metodos.Login().Equals(true))
                {
                    Console.Clear();
                    metodos.Menu();
                }
                else
                {
                    Console.Clear();
                    metodos.Login();
                }
            Console.ReadKey();
        }
    }
}