using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Barbaro : Guerreiro
        {
            public override string Nome => "Bárbaro";

            public override int PontosVidaInicial =>
                base.PontosVidaInicial + 2;

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Vigor Bárbaro");
                Console.WriteLine("Talentos Selvagens");
            }
        }
}
