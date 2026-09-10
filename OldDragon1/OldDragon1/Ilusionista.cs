using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Ilusionista : Mago
        {
            public override string Nome => "Ilusionista";

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Magias Exclusivas de Ilusão");
                Console.WriteLine("Ilusão Melhorada");
                Console.WriteLine("Miragem");
                Console.WriteLine("Ilusão Permanente");
            }
        }
}
