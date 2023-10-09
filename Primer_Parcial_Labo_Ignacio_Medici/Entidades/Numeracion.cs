namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
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

        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
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
                this.valor = msgError;
            }
        }

        protected virtual bool EsNumeracionValida(string valor)
        {
            return string.IsNullOrEmpty(valor);
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (ReferenceEquals(n1, null) && ReferenceEquals(n2, null))
            {
                return true;
            }
            else if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null))
            {
                return false;
            }

            else if (n1.GetType() != n2.GetType())
            {
                return false;
            }

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