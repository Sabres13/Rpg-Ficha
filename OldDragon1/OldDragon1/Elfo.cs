using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Elfo : Raca
        {
            public override string Nome => "Elfo";
            public override int Movimento => 9;
            public override int Infravisao => 18;
            public override string Alinhamento => "Neutralidade";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Percepção Natural");
                Console.WriteLine("Gracioso");
                Console.WriteLine("Arma Racial");
                Console.WriteLine("Imunidades");
            }
        }
}
