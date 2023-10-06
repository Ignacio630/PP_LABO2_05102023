namespace Entidades
{
    public abstract class Numeracion
    {
        protected string msgError;
        protected string valor;

        public string Valor
        {
            get { return this.valor; }
        }

        public abstract double ValorNumerico
        {
            get;
        }


        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        private Numeracion()
        {
            this.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
            :this()
        {
            this.InicializaValor(valor);
        }
        private void InicializaValor(string valor)
        {
            if(this.EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = this.msgError;
            }
        }

        protected bool EsNumeracionValida(string valor)
        {
            return string.IsNullOrEmpty(valor);
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.valor == n2.valor;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.valor != n2.valor;
        }
        public static explicit operator double(Numeracion n1)
        {
            return n1.ValorNumerico;
        }
    }
}