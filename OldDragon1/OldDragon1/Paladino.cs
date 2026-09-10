using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Paladino : Guerreiro
        {
            public override string Nome => "Paladino";

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Imunidade a Doenças");
                Console.WriteLine("Cura pelas Mãos");
                Console.WriteLine("Aura de Proteção");
                Console.WriteLine("Espada Sagrada");
            }
        }
}
