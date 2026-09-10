using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
    public class CriacaoHeroica : CriacaoBase
    {
        public override bool PermiteDistribuir => true;

        protected override int GerarValor()
        {
            return Dados.Rolar4D6DescartarMenor();
        }
    }
}