using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Druida : Clerigo
        {
            public override string Nome => "Druida";

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Magias Druídicas");
                Console.WriteLine("Forma Animal");
            }
        }
}
