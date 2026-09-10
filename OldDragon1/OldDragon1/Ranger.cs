using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Ranger : Ladrao
        {
            public override string Nome => "Ranger";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Talentos de Ranger");
                Console.WriteLine("Percepção");
                Console.WriteLine("Rastrear");
                Console.WriteLine("Inimigo Mortal");
                Console.WriteLine("Previdência");
                Console.WriteLine("Companheiro Animal");
            }
        }
}
