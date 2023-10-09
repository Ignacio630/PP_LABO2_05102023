using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public override double ValorNumerico
        {
            get
            {
                double.TryParse(this.valor, out double valorNumerico);

                return valorNumerico;
            }
        }

        public SistemaBinario(string valor)
            :base(valor)
        {
            this.valor = valor;    
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return this;
        }

        private bool EsSistemaBinarioValido(string valor)
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
        protected new bool EsNumeracionValida(string valor)

        {
            return string.IsNullOrWhiteSpace(valor) && this.EsSistemaBinarioValido(valor);
        }

        private SistemaDecimal BinarioADecimal()
        {
            if(this.valor != msgError)
            {
                return new SistemaDecimal(this.valor);
            }
            else
            {
                return double.MinValue;
            }
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor.ToString());
        }
    }
}
