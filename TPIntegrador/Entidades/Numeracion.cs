using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema {Decimal, Binario };
        private double valorNumerico;
        private ESistema sistema;

        public Numeracion(double valorNumerico, ESistema sistema)
            :this(valorNumerico.ToString(), sistema) 
        {
            
        }

        public Numeracion(string valorNumerico, ESistema sistema) 
        {
            this.InicializarValores(valorNumerico, sistema);
        }

        public ESistema Sistema 
        { 
            get 
            { 
                return this.sistema; 
            } 
        }

        public string Valor
        {
            get 
            { 
                return valorNumerico.ToString();
            }
        }

        private void InicializarValores(string valor, ESistema sistema)
        {
            double auxValue = this.BinarioADecimal(valor);
            if (auxValue != 0 && sistema == ESistema.Binario)
            {
                this.valorNumerico = auxValue;
            }
            else if (double.TryParse(valor, out auxValue))
            {
                this.valorNumerico = auxValue;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
            this.sistema = sistema;
        }
        public string DecimalABinario(string valor)
        {
            string rtn = "";
            if (double.TryParse(valor, out double numeroDecimal))
            {
                if ((int)numeroDecimal == 0)
                {
                    rtn = "0";
                }
                else if ((int)numeroDecimal == 1)
                {
                    rtn = "1";
                }
                else if ((int)numeroDecimal < 0)
                {
                    rtn = "Número inválido";
                }
                else
                {
                    int resu;
                    int par;
                    //int auxNumeroDecimal;
                    string bin = "0";
                    bool bandera = false;
                    do
                    {
                        resu = (int)(numeroDecimal / 2);
                        par = (int)(numeroDecimal % 2);
                        if (bandera == false)
                        {
                            bin = par.ToString();
                            numeroDecimal = resu;
                            bandera = true;
                            if (resu == 1)
                            {
                                bin = bin + resu.ToString();
                            }
                        }
                        else
                        {
                            bin = bin + par.ToString();
                            numeroDecimal = resu;
                            if (resu == 1)
                            {
                                bin = bin + resu.ToString();
                            }
                        }

                    } while (resu != 1);

                    StringBuilder sb = new StringBuilder();

                    for (int i = bin.Length - 1; i >= 0; i--)
                    {
                        sb.Append(bin[i]);

                    }
                    rtn = sb.ToString();
                }
            }
            else
            {
                rtn =  "Número decimal inválido.";
            }

            return rtn;
        }
        public string DecimalABinario(int valor)
        {
            return DecimalABinario(valor.ToString());
        }

        public double BinarioADecimal(string valor)
        {
            double resu = 0;
            int potencia = 0;
            if (EsBinario(valor))
            {
                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    if (valor[i] == '1')
                    {
                        resu += Math.Pow(2, potencia);
                    }
                    potencia++;
                }
            }

            return resu;
        }
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.valorNumerico.ToString();
            }
            else
            { 
                return this.DecimalABinario(this.Valor);
            }
        }
        private bool EsBinario(string valor)
        {
            foreach (char caracter in valor)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        { 
            return !(n1 == n2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Numeracion n)
            {
                return this == n;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.sistema.GetHashCode();
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        { 
            return sistema == numeracion.sistema;
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.sistema);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico + n2.valorNumerico,ESistema.Decimal);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n2.valorNumerico, ESistema.Decimal);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n2.valorNumerico != 0)
            {
                return new Numeracion(n1.valorNumerico / n2.valorNumerico, ESistema.Decimal);
            }
            return new Numeracion("Numero invalido", ESistema.Binario);
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n2.valorNumerico, ESistema.Decimal);
        }
    }
}