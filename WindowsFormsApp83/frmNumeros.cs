using System;
using System.Windows.Forms;

namespace WindowsFormsApp83
{
    public partial class frmNumeros : Form
    {
        public frmNumeros()
        {
            InitializeComponent();
        }

        private int[] numeros = new int[100];
        private void generarButton_Click(object sender, EventArgs e)
        {
            GenerarNumeros();
            MessageBox.Show("Generación finalizada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarNumeros();
        }

        private void MostrarNumeros()
        {
            numerosListBox.Items.Clear();
            foreach (var numero in numeros)
            {
                numerosListBox.Items.Add(numero);
            }

            estadisticasButton.Enabled = true;
        }

        private void GenerarNumeros()
        {
            Random r = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = r.Next(1, 11);
            }
        }

        private void estadisticasButton_Click(object sender, EventArgs e)
        {
            frmEstadisticas frm = new frmEstadisticas() {Text = "Estadísticas de nros. generados"};
            frm.SetArray(numeros);
            frm.ShowDialog(this);
            InicializarControles();
        }

        private void InicializarControles()
        {
            numerosListBox.Items.Clear();
            estadisticasButton.Enabled = false;

        }
    }
}
