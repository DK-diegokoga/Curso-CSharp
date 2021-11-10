using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
   /* //variavel global delegate que referencia os metodos da classe Matematica
    delegate int Operacao(int n1, int n2);
    class Matematica
    {
        public static int Soma(int n1,int n2)
        {
            return n1 + n2;
        }

        public static int Multiplica(int n1, int n2)
        {
            return n1 * n2;
        }
    }

    class Aula50
    {
        static void Main()
        {
            int resultado;
            Operacao delegate1 = new Operacao(Matematica.Soma);
            resultado = delegate1(10, 10);
            Console.WriteLine(resultado);

            //não precisamos colocar a Operacao de novo para instanciar apontando para outro metodo
            delegate1 = new Operacao(Matematica.Multiplica);
            resultado = delegate1(10, 10);
            Console.WriteLine(resultado);

        }
    }*/
}
