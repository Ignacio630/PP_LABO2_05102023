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

        public Numeracion PrimerOperador
        {
            get
            {
                return this.primerOperando;
            }
            set { this.primerOperando = value; }
        }

        public Numeracion SegundoOperador
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
            this.sistema = ESistema.Decimal;
        }

    }
}
