using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor // Não consegue herdar pois a classe Professor está selada
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor!");
        }
    }
}