using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando, segundoOperando, resultado;
        private ESistema sistema;

        public string NombreAlumno
        {
            get 
            { 
                return this.nombreAlumno; 
            } 
            set 
            {  
                this.nombreAlumno = value; 
            }
        }

        public List<string> Operaciones
        {
            get
            {
                return this.operaciones;
            }
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
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
                return this.segundoOperando;
            }
            set 
            { 
                this.segundoOperando = value; 
            }
        }

        public Numeracion Resultado
        {
            get
            {
                return this.resultado;
            }
        }

        public ESistema Sistema
        {
            get 
            {
                return this.sistema;
            }
            set
            {
                this.sistema = value;
            }
        }

        
        public Calculadora()
        {
            this.operaciones = new List<string>();
            this.sistema = ESistema.Decimal;
        }

        private Numeracion MapeaResultado(double valor)
        {
            if(this.sistema == ESistema.Decimal)
            {
                return this.resultado.CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
            else if (this.sistema == ESistema.Binario)
            {
                return this.resultado.CambiarSistemaDeNumeracion(ESistema.Binario);
            }
            else
            {
                return this.resultado;
            }
        }

        public void Calcular()
        {

        }

        public void Calcular(char operador)
        {
            double auxValorPrimerOperando = this.PrimerOperando.ValorNumerico();
            double auxValorSegundoOperando = this.SegundoOperando.ValorNumerico();
            switch (operador)
            {
                case '+':
                    this.resultado = new SistemaDecimal((auxValorPrimerOperando + auxValorSegundoOperando).ToString());
                    break;
                case '-':
                    this.resultado = new SistemaDecimal((auxValorPrimerOperando - auxValorSegundoOperando).ToString());
                    break;
                case '*':
                    this.resultado = new SistemaDecimal((auxValorPrimerOperando * auxValorSegundoOperando).ToString());
                    break;
                case '/':
                    if (segundoOperando.ValorNumerico() == 0)
                    {
                        this.resultado = new SistemaDecimal("0");
                    }
                    else
                    {
                        this.resultado = new SistemaDecimal((auxValorPrimerOperando / auxValorSegundoOperando).ToString());
                    }
                    break;
                default:
                    this.resultado = new SistemaDecimal(auxValorPrimerOperando.ToString());
                    break;
            }
        }
        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Sistema);
            builder.Append(" - ");
            builder.Append(primerOperando.Valor);
            builder.Append(" - ");
            builder.Append(primerOperando.Valor);
            builder.Append(" - ");
            builder.Append(operador);
            builder.Append(" - ");
            builder.Append(segundoOperando.Valor);

            this.operaciones.Add(builder.ToString());
            
        }
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }
    }
}
