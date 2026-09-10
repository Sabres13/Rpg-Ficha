using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Ladrao : ClassePersonagem
        {
            public override string Nome => "Ladrão";

            public override int PontosVidaInicial => 6;

            public override int BaseAtaqueInicial => 1;

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Ataque Furtivo");
                Console.WriteLine("Ouvir Ruídos");
                Console.WriteLine("Talentos de Ladrão");
            }
        }
}
