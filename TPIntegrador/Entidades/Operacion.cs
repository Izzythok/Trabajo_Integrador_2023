using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando 
        {   
            get
            {
                return primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }
        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.PrimerOperando = primerOperando;
            this.SegundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operar)
        {
            if (this.primerOperando.Sistema == Numeracion.ESistema.Decimal && this.segundoOperando.Sistema == Numeracion.ESistema.Decimal)
            {
                switch (operar)
                {
                    case '+':
                        return this.primerOperando + this.SegundoOperando;
                    case '-':
                        return this.primerOperando - this.SegundoOperando;
                    case '/':
                        return this.primerOperando / this.SegundoOperando;
                    case '*':
                        return this.primerOperando * this.SegundoOperando;
                    default:
                        return this.primerOperando + this.SegundoOperando;

                }
            }
            else
            {
                return new Numeracion("Operacion Invalido", Numeracion.ESistema.Binario);
            }
        }
    }
}
