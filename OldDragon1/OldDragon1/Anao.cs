using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Anao : Raca
        {
            public override string Nome => "Anão";
            public override int Movimento => 6;
            public override int Infravisao => 18;
            public override string Alinhamento => "Ordem";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Mineradores");
                Console.WriteLine("Vigoroso");
                Console.WriteLine("Restrição a armas grandes");
                Console.WriteLine("Inimigos naturais");
            }
        }
}
