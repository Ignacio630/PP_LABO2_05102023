namespace Primer_Parcial_Labo
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            txtPrimerOperando = new TextBox();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            txtSegundoOperando = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            cmbOperacion = new ComboBox();
            lblOperacion = new Label();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 38);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(232, 54);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado: ";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(12, 305);
            txtPrimerOperando.Multiline = true;
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(232, 45);
            txtPrimerOperando.TabIndex = 1;
            txtPrimerOperando.TextChanged += TxtBPrimerOperador_TextChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(12, 274);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(182, 28);
            lblPrimerOperador.TabIndex = 2;
            lblPrimerOperador.Text = "Primer Operador: ";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(556, 274);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(198, 28);
            lblSegundoOperador.TabIndex = 4;
            lblSegundoOperador.Text = "Segundo operador: ";
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(556, 305);
            txtSegundoOperando.Multiline = true;
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(232, 45);
            txtSegundoOperando.TabIndex = 3;
            txtSegundoOperando.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 384);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(269, 54);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(287, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(243, 54);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(536, 384);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(252, 54);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(287, 129);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(200, 100);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en: ";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(104, 48);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(69, 23);
            rdbBinario.TabIndex = 0;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.BackgroundImageLayout = ImageLayout.Zoom;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(23, 48);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(75, 23);
            rdbDecimal.TabIndex = 1;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(333, 305);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(114, 45);
            cmbOperacion.TabIndex = 2;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(333, 263);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(114, 28);
            lblOperacion.TabIndex = 11;
            lblOperacion.Text = "Operacion:";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(807, 164);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(390, 274);
            lstHistorial.TabIndex = 14;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(943, 129);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(93, 28);
            lblHistorial.TabIndex = 15;
            lblHistorial.Text = "Historial";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 450);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(lblSegundoOperador);
            Controls.Add(txtSegundoOperando);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Ignacio Medici";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtPrimerOperando;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private TextBox txtSegundoOperando;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private Label lblOperacion;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}