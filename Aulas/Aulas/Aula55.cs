using System;
using System.Collections.Generic;

namespace Aulas
{
   /* class Aula55
    {
        static void Main()
        {
            //criando coleção
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            //adicionando items a coleção
            //chave e valor
            veiculos.Add(10,"Carro");
            veiculos.Add(5, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");

            //removendo valor da coleção
            veiculos.Remove(20);

            //remover tudo da coleção
            //veiculos.Clear();

            //contador de quantos itens tem na coleção
            Console.WriteLine($"Tamanho do Dictionary: {veiculos.Count}");
            
            //metodo contais KEY
            int chave = 20;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine($"A chave {chave} esta na coleção");
            }
            else
            {
                Console.WriteLine($"A chave {chave} não existe na coleção");
            }

            //metodo contains VALUE
            string valor = "Carro";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine($"A chave {valor} esta na coleção");
            }
            else
            {
                Console.WriteLine($"A chave {valor} não existe na coleção");
            }


            Dictionary<int, string>.ValueCollection valores = veiculos.Values;
            foreach (string s in valores)
            {
                Console.WriteLine(s);
            }
            /*
            foreach (KeyValuePair<int,string> s in veiculos)
            {
                Console.WriteLine(s.Key);
            }
            

        }
    }*/
}
