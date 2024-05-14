using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrador_tp3
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtResultadoE1.Enabled = false;
            txtResultadoE2.Enabled = false;

            for (int i = 0; i < 120; i++)
            {
                grdTablaMontecarlo.Rows.Add();
                grdTablaMontecarlo.Rows[i].Cells["Dias"].Value = i + 1;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtCostoStockOut.Text != "" && txtCostoUnitario.Text != "" && txtReembolso.Text != "")
            {
                MessageBox.Show("Faltan parametros por agregar...");
                return;
            }

            if (ckE1.Checked && ckE2.Checked)
            {
                MessageBox.Show("Elija solo una estrategia...");
                return;
            }

            if (ckE1.Checked)
            {
                //Se envian los parametros a la estrategia 1
            }
            
            if (ckE2.Checked && !ckE1.Checked)
            {
                if (txtCantidadFija.Text == "")
                {
                    MessageBox.Show("Falta la cantidad fija...");
                }
                else
                {
                    //se envian los parametros a la estrategia 2
                }
            }
        }
    }
}
