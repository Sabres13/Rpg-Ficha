using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
   
    public static class Dados
    {
        private static Random random = new Random();

        public static int RolarD6()
        {
            return random.Next(1, 7);
        }

        public static int Rolar3D6()
        {
            return RolarD6()
                 + RolarD6()
                 + RolarD6();
        }

        public static int Rolar4D6DescartarMenor()
        {
            int[] dados =
            {
                RolarD6(),
                RolarD6(),
                RolarD6(),
                RolarD6()
            };

            Array.Sort(dados);

            return dados[1] + dados[2] + dados[3];
        }
    }
}