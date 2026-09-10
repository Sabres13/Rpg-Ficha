using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public abstract class ClassePersonagem
        {
            public abstract string Nome { get; }

            public abstract int PontosVidaInicial { get; }

            public abstract int BaseAtaqueInicial { get; }

        public virtual void Aplicar(FichaOldDragon ficha)
        {
            ficha.Classe = Nome;
            ficha.PontosVida = PontosVidaInicial;
            ficha.PontosVidaMaximos = PontosVidaInicial;
            ficha.BaseAtaque = BaseAtaqueInicial;
        }

        public abstract void ExibirHabilidades();
        }
}
