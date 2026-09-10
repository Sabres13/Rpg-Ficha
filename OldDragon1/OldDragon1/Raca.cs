using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public abstract class Raca
        {
            public abstract string Nome { get; }

            public abstract int Movimento { get; }

            public abstract int Infravisao { get; }

            public abstract string Alinhamento { get; }

        public virtual void Aplicar(FichaOldDragon ficha)
        {
            ficha.Raca = Nome;
            ficha.Movimento = Movimento;
            ficha.Infravisao = Infravisao;
            ficha.Alinhamento = Alinhamento;
        }

        public abstract void ExibirHabilidades();
        }
}
