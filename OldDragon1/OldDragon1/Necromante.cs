using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Necromante : Mago
        {
            public override string Nome => "Necromante";

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Magias Exclusivas de Necromancia");
                Console.WriteLine("Toque Sombrio");
                Console.WriteLine("Aterrorizar");
                Console.WriteLine("Criar Mortos-Vivos");
                Console.WriteLine("Drenar Vida");
                Console.WriteLine("Magia da Morte");
            }
        }
}
