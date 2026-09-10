using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Mago : ClassePersonagem
        {
            public override string Nome => "Mago";

            public override int PontosVidaInicial => 4;

            public override int BaseAtaqueInicial => 0;

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Magias Arcanas");
                Console.WriteLine("Ler Magias");
                Console.WriteLine("Detectar Magias");
            }
        }
}
