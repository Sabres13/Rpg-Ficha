using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public abstract class CriacaoBase : IMetodoCriacao
        {
            public abstract bool PermiteDistribuir { get; }

            protected abstract int GerarValor();

            public int[] GerarAtributos()
            {
                int[] valores = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    valores[i] = GerarValor();
                }

                return valores;
            }
        }
}
