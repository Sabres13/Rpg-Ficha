using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Guerreiro : ClassePersonagem
        {
            public override string Nome => "Guerreiro";
            public override int PontosVidaInicial => 10;
            public override int BaseAtaqueInicial => 1;

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Aparar");
                Console.WriteLine("Maestria em Arma");
            }
        }
}
