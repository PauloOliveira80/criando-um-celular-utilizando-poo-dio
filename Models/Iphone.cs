using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCelularPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, string memory) : base(number, model, imei, memory)
        {
        }

        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"O aplicativo {nomeAplicativo} foi instalado com sucesso em seu Iphone.");
        }

    }
}