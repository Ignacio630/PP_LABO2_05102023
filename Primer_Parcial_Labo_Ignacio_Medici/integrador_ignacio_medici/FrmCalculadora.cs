using Entidades;

namespace Primer_Parcial_Labo
{
    public partial class FrmCalculadora : Form
    {
        Calculadora calculadora = new Calculadora();

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora ? ", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TxtBPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperando(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperando(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado:{calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = ESistema.Decimal;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = ESistema.Binario;
        }

        private void setResultado()
        {

        }

        private void MostrarHistorial()
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        private Numeracion GetOperando(string value)
        {
            if (calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }
    }
}