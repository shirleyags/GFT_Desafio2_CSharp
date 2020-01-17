using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.VeiculosTipo;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro();
            

            Console.WriteLine(carro.Modelo);
            Console.WriteLine(carro.Velocidade);
            Console.WriteLine(carro.Passageiros);


            Aviao aviao = new Aviao();
            aviao.Modelo = "boing";
            aviao.Velocidade = 1000;
            aviao.Passageiros = 100;

            Console.WriteLine(aviao.Modelo);
            Console.WriteLine(aviao.Velocidade);
            Console.WriteLine(aviao.Passageiros);

            Console.ReadLine();

        }
    }
}
