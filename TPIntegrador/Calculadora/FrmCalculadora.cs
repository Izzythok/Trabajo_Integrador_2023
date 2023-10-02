using Entidades;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operacion? calculadora;
        private Numeracion? primerOperando;
        private Numeracion? segundoOperando;
        private Numeracion? resultado;
        private Numeracion.ESistema sistema;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resu = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resu == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cbxOperacion.DataSource = new char[] { ' ', '+', '-', '/', '*' };
            this.rdbDecimal.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.lblValor.Text = string.Empty;
            this.resultado = null;

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (this.cbxOperacion.SelectedIndex != 0 && this.rdbDecimal.Checked == true)
                {
                    string operacion = this.cbxOperacion.Text;
                    this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
                    this.resultado = calculadora.Operar(operacion[0]);
                    this.setResultado();
                }
                else
                {
                    MessageBox.Show("Se debe elejir una operacion en Decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos de operacion no pueden esta vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setResultado()
        {
            if (this.resultado is not null)
            {
                if (this.resultado.Valor != double.MinValue.ToString())
                {
                    this.lblValor.Text = this.resultado.ConvertirA(this.sistema);
                }
                else
                {
                    this.lblValor.Text = "valores mal ingresados";
                }
            }

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Numeracion.ESistema.Decimal;
            this.setResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = Numeracion.ESistema.Binario;
            this.setResultado();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(textBox1.Text, this.sistema);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(textBox2.Text, this.sistema);
        }
    }
}