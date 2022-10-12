using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp83
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private int[] numeros;
        private void cerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetArray(int[] numeros)
        {
            this.numeros = numeros;
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            MostrarEstadisticas();
        }

        private void MostrarEstadisticas()
        {
            estadisticasDataGridView.Rows.Clear();

            for (int i = 1; i <= 10; i++)
            {
                int cantidad=GenerarEstadistica(i);
                DataGridViewRow r = CrearFila(estadisticasDataGridView);
                SetearFila(r, i,cantidad);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            estadisticasDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, int i, int cantidad)
        {
            r.Cells[colNumero.Index].Value = i;
            r.Cells[colCantidad.Index].Value = cantidad;

        }

        private DataGridViewRow CrearFila(DataGridView dataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;
        }

        private int GenerarEstadistica(int i)
        {
            int contador = 0;
            foreach (var numero in numeros)
            {
                if (numero==i)
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
