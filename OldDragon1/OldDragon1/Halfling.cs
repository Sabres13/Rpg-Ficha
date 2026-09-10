using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Halfling : Raca
        {
            public override string Nome => "Halfling";
            public override int Movimento => 6;
            public override int Infravisao => 0;
            public override string Alinhamento => "Neutralidade";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Furtivo");
                Console.WriteLine("Destemido");
                Console.WriteLine("Bom de Mira");
                Console.WriteLine("Pequeno");
                Console.WriteLine("Restrições de equipamentos");
            }
        }
}
