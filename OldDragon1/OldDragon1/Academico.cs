using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Academico : Clerigo
        {
            public override string Nome => "Acadêmico";

            public override void ExibirHabilidades()
            {
                base.ExibirHabilidades();

                Console.WriteLine("Conhecimento Acadêmico");
                Console.WriteLine("Especialização");
            }
        }
}
