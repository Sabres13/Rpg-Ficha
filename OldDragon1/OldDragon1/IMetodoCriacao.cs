using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
    public interface IMetodoCriacao
    {
        int[] GerarAtributos();

        bool PermiteDistribuir { get; }
    }
}