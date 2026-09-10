using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
    public class CriacaoClassica : CriacaoBase
    {
        public override bool PermiteDistribuir => false;

        protected override int GerarValor()
        {
            return Dados.Rolar3D6();
        }
    }
}
