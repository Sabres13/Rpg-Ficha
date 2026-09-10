using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Humano : Raca
        {
            public override string Nome => "Humano";
            public override int Movimento => 9;
            public override int Infravisao => 0;
            public override string Alinhamento => "Qualquer";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Aprendizado: recebe 10% de bônus de XP.");
                Console.WriteLine("Adaptabilidade: +1 em uma JP à escolha.");
            }
        }
}
