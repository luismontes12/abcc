using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET
{
    class Departamento
    {
        private int numdep;
        private string nomdep;

        public int Numero_departamento { get { return this.numdep; } set { this.numdep = value; } }
        public string Nombre_departamento { get { return this.nomdep; } set { this.nomdep = value; } }
    }
}
