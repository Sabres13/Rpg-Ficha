using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class Bardo : Ladrao
        {
            public override string Nome => "Bardo";

            public override void ExibirHabilidades()
            {
                Console.WriteLine("Ouvir Ruídos");
                Console.WriteLine("Talentos de Ladrão");
                Console.WriteLine("Cultura");
                Console.WriteLine("Decifrar");
                Console.WriteLine("Influenciar");
                Console.WriteLine("Inspirar");
                Console.WriteLine("Fascinar");
                Console.WriteLine("Usar Pergaminhos");
            }
        }
}
