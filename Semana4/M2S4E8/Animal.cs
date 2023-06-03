using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana4.M2S4E8
{
    public abstract class Animal
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public abstract void EmitirSom();
    }
}