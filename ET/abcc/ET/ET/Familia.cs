using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    class Familia
    {
        private int numfam;
        private string nomfam;

        public int numero_familia { get { return this.numfam; } set { this.numfam = value; } }
        public string nombre_familia { get { return this.nomfam; } set { this.nomfam = value; } }
    }
}
