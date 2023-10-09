using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class SistemaDecimal : Numeracion
    {

        public override double ValorNumerico
        {
            get
            {
                double.TryParse(this.Valor, out double valorNumerico);
                return valorNumerico;
            }
        }

        
        public SistemaDecimal(string valor) 
            :base(valor)
        {
            base.valor = DecimalABinario(valor);
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        { 
            if(sistema == ESistema.Decimal) 
            {
                return new SistemaDecimal(this.ValorNumerico.ToString());
            }
            else
            {
                return new SistemaBinario(this.ValorNumerico.ToString());
            }
        }

        protected new bool EsNumeracionValida(string valor)
            
        {
            return string.IsNullOrWhiteSpace(valor) && this.EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double numero);
        }

        private SistemaBinario DecimalABinario()
        {
            if(this.ValorNumerico >= 0) 
            {
                return new SistemaBinario(this.ValorNumerico.ToString());
            }
            else
            {
                return new SistemaBinario(msgError);
            }
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

    }
}
