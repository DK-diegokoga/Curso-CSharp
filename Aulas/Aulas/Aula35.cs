using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
   /* //classe Base
    class Veiculo
    {
        private int rodas;
        public int velMax;
        private bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public string GetLigado()
        {
            return (ligado ? "sim" : "não");
        }
        public int GetRodas()
        {
            return rodas;
        }
        public void SetRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }else if(rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }
    //classe filho
    class Carro : Veiculo
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor) : base(4)//refente a classe base
        {
            Desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }

    }

    class CarroCombate : Carro
    {
        public int monicao;
        public CarroCombate():base("Carro de Combate","Preto")
        {
            monicao = 100;
            SetRodas(6);
        }
    }

    class Aula35
    {
        static void Main()
        {
            Carro car1 = new Carro("Carro", "Vermelho");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine($"Cor..............: {car1.cor}");
            Console.WriteLine($"Nome.............: {car1.nome}");
            Console.WriteLine($"Rodas............: {car1.GetRodas()}");
            Console.WriteLine($"Velocidade Maxima: {car1.velMax}");
            Console.WriteLine($"Ligado...........: {car1.GetLigado()}");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"Cor..............: {cc1.cor}");
            Console.WriteLine($"Nome.............: {cc1.nome}");
            Console.WriteLine($"Rodas............: {cc1.GetRodas()}");
            Console.WriteLine($"Velocidade Maxima: {cc1.velMax}");
            Console.WriteLine($"Ligado...........: {cc1.GetLigado()}");
            Console.WriteLine($"Monição..........: {cc1.monicao}");
        }
    }*/
}
