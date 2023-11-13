using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_questao03
{
    internal class NoPilha
    {
        private string codigo;
        private NoPilha anterior;

        public NoPilha()
        {
            this.Anterior = null;
        }
        public NoPilha(string codigo)
        {
            this.Codigo = codigo;
            this.Anterior = null;
        }

        public NoPilha(string codigo, NoPilha anterior)
        {
            this.Codigo = codigo;
            this.Anterior = anterior;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        internal NoPilha Anterior { get => anterior; set => anterior = value; }
    }
}
