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
            double[,] tablaProbabilidades = GenerarTablaProbabilidades();
            
            if (txtCostoStockOut.Text == "" || txtCostoUnitario.Text == "" || txtReembolso.Text == "")
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

        private double[,] GenerarTablaProbabilidades()
        {
            double[,] matriz = new double[6,2];

            //cantidades vendidas
            matriz[0,0] = 20;
            matriz[1,0] = 21;
            matriz[2,0] = 22;
            matriz[3,0] = 23;
            matriz[4,0] = 24;
            matriz[5,0] = 25;

            //Limite inferior de probabilidades de aparicion
            matriz[0,1] = 0.0;
            matriz[1,1] = 0.05;
            matriz[2,1] = 0.15;
            matriz[3,1] = 0.3;
            matriz[4,1] = 0.6;
            matriz[5,1] = 0.85;

            return matriz;
        }
    }
}
