using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Clerigo : ClassePersonagem
        {
            public override string Nome => "Clérigo";

            public override int PontosVidaInicial => 8;

            public override int BaseAtaqueInicial => 0;

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Magias Divinas");
                Console.WriteLine("Afastar Mortos-Vivos");
            }
        }
}
