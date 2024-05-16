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
        private List<double> diaAnterior;
        private List<double> diaActual;
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtResultadoE1.Enabled = false;
            txtResultadoE2.Enabled = false;

            grdTablaMontecarlo.Rows.Add();

            List<double> dia = new List<double>();

            for (int i = 0; i < 13; i++)
            {
                dia.Add(0.0);
            }

            dia[0] = 0.0;
            dia[3] = 30.0;
            dia[5] = 8.0;

            this.diaAnterior = dia;

            for (int i = 0; i < dia.Count; i++)
            {
                grdTablaMontecarlo.Rows[0].Cells[i].Value = dia[i];
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {   
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
                double costoUnitario = double.Parse(txtCostoUnitario.Text);
                double costoStockOut = double.Parse(txtCostoStockOut.Text);
                double reembolso = double.Parse(txtReembolso.Text);
                double[,] tablaProbabilidades = GenerarTablaProbabilidades();

                List<double> diaAnterior = this.diaAnterior;
                diaAnterior[6] = diaAnterior[3] + diaAnterior[5];

                //Se envian los parametros a la estrategia 1
                for (int fila = 0; fila < 120; fila++)
                {
                    diaActual = Estrategia1.Montecarlo(costoUnitario, costoStockOut, reembolso,
                         tablaProbabilidades, diaAnterior);
                    for (int col = 0; col < 13; col++)
                    {
                        grdTablaMontecarlo.Rows.Add();
                        grdTablaMontecarlo.Rows[fila + 1].Cells[col].Value = diaActual[col];
                    }

                    diaAnterior = diaActual;
                }
                
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
            double[,] matriz = new double[6,3];

            //cantidades vendidas
            matriz[0,0] = 20.0;
            matriz[1,0] = 21.0;
            matriz[2,0] = 22.0;
            matriz[3,0] = 23.0;
            matriz[4,0] = 24.0;
            matriz[5,0] = 25.0;

            //Limite inferior de probabilidades de aparicion
            matriz[0,1] = 0.0;
            matriz[1,1] = 0.05;
            matriz[2,1] = 0.15;
            matriz[3,1] = 0.3;
            matriz[4,1] = 0.6;
            matriz[5,1] = 0.85;

            return matriz;
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            txtResultadoE1.Text = "";
            txtResultadoE2.Text = "";

            grdTablaMontecarlo.Rows.Clear();

            grdTablaMontecarlo.Rows.Add();

            List<double> dia = new List<double>();

            for (int i = 0; i < 13; i++)
            {
                dia.Add(0.0);
            }

            dia[0] = 0.0;
            dia[3] = 30.0;
            dia[5] = 8.0;

            this.diaAnterior = dia;

            for (int i = 0; i < dia.Count; i++)
            {
                grdTablaMontecarlo.Rows[0].Cells[i].Value = dia[i];
            }

        }
    }
}
