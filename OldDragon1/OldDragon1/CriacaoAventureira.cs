using System;
using System.Collections.Generic;
using System.Text;


namespace OldDragon1
{
    public class CriacaoAventureira : CriacaoBase
    {
        public override bool PermiteDistribuir => true;

        protected override int GerarValor()
        {
            return Dados.Rolar3D6();
        }
    }
}