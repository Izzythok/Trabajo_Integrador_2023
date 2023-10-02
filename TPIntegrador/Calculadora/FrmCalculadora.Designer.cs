namespace Calculadora
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cbxOperacion = new ComboBox();
            lblPrimerOperardor = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            grpBoxRepresentar = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            lblValor = new Label();
            grpBoxRepresentar.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 376);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(135, 48);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 376);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 48);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(373, 376);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(135, 48);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 321);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // cbxOperacion
            // 
            cbxOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOperacion.FormattingEnabled = true;
            cbxOperacion.Location = new Point(194, 321);
            cbxOperacion.Name = "cbxOperacion";
            cbxOperacion.Size = new Size(135, 23);
            cbxOperacion.TabIndex = 2;
            // 
            // lblPrimerOperardor
            // 
            lblPrimerOperardor.AutoSize = true;
            lblPrimerOperardor.Location = new Point(12, 303);
            lblPrimerOperardor.Name = "lblPrimerOperardor";
            lblPrimerOperardor.Size = new Size(102, 15);
            lblPrimerOperardor.TabIndex = 7;
            lblPrimerOperardor.Text = "Primer Operardor:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(194, 303);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(65, 15);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Location = new Point(373, 303);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(110, 15);
            lblSegundoOperador.TabIndex = 9;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // grpBoxRepresentar
            // 
            grpBoxRepresentar.Controls.Add(rdbBinario);
            grpBoxRepresentar.Controls.Add(rdbDecimal);
            grpBoxRepresentar.Location = new Point(151, 202);
            grpBoxRepresentar.Name = "grpBoxRepresentar";
            grpBoxRepresentar.Size = new Size(217, 81);
            grpBoxRepresentar.TabIndex = 10;
            grpBoxRepresentar.TabStop = false;
            grpBoxRepresentar.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(120, 41);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 5;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(20, 41);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 4;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = SystemColors.InfoText;
            lblResultado.Location = new Point(41, 75);
            lblResultado.Margin = new Padding(10, 0, 10, 0);
            lblResultado.MaximumSize = new Size(50, 50);
            lblResultado.MinimumSize = new Size(100, 30);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 30);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(147, 75);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(0, 15);
            lblValor.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 455);
            Controls.Add(lblValor);
            Controls.Add(lblResultado);
            Controls.Add(grpBoxRepresentar);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperardor);
            Controls.Add(cbxOperacion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora Alumno: Rojas Nahuel";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpBoxRepresentar.ResumeLayout(false);
            grpBoxRepresentar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cbxOperacion;
        private Label lblPrimerOperardor;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private GroupBox grpBoxRepresentar;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultado;
        private Label lblValor;
    }
}