using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
        public class CriadorPersonagem
        {
            private IMetodoCriacao metodo;

            public CriadorPersonagem(IMetodoCriacao metodo)
            {
                this.metodo = metodo;
            }

            public void MudarMetodo(IMetodoCriacao novoMetodo)
            {
                metodo = novoMetodo;
            }

            public int[] GerarAtributos()
            {
                return metodo.GerarAtributos();
            }

            public bool PermiteDistribuir()
            {
                return metodo.PermiteDistribuir;
            }
        }
}
