using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador_tp3
{
    internal class Estrategia2
    {
        //Esta estrategia debe recibir por parametro los 3 costos y la tabla de probabilidades
        //y el pedido del dia siguiente siempre es de 23 unidades

        public static List<double> Montecarlo(double costoUnitario, double costoStockOut, double reembolso,
            double[,] tablaProbabilidades, List<double> diaAnterior, int cantidadFija)
        {
            //la lista que devuleve esta funcion debe contener lo siguiente
            /*
             * 0-Reloj en dias
             * 1-Stock actual
             * 2-RND Demanda
             * 3-Cantidad vendida
             * 4-Para Reembolso
             * 5-Stock Out
             * 6-Pedido del dia siguiente
             * 7-Costo ejemplares vendidos
             * 8-Costo stock out
             * 9-Ganancia por reembolso
             * 10-Total costo diario
             * 11-Acumulador de costos
             * 12-Costo promedio diario
             */

            List<double> diaActual = new List<double>();

            for (int i = 0; i < 13; i++)
            {
                diaActual.Add(0);
            }

            Random random = new Random();
            double rnd = random.NextDouble();

            //reloj
            diaActual[0] = diaAnterior[0] + 1;
            //stock diario
            double stockDiario = diaAnterior[6];
            diaActual[1] = stockDiario;
            //RND
            diaActual[2] = Math.Round(rnd, 4);
            //cantidad vendida
            double cantidadVendida = BuscarCantidadVendida(rnd, tablaProbabilidades);
            diaActual[3] = cantidadVendida;

            if (cantidadVendida < stockDiario)
            {
                //para reembolso
                diaActual[4] = stockDiario - cantidadVendida;
                //stock out
                diaActual[5] = 0;
            }
            else
            {
                diaActual[4] = 0;
                diaActual[5] = cantidadVendida - stockDiario;
            }
            //pedido dia siguiente
            diaActual[6] = cantidadFija;

            //costo de ejemplares vendidos
            diaActual[7] = cantidadVendida * costoUnitario;

            //Costo stockout
            diaActual[8] = diaActual[5] * costoStockOut;

            //beneficio de reembolso
            diaActual[9] = diaActual[4] * reembolso;

            //costo total
            diaActual[10] = diaActual[7] + diaActual[8] - diaActual[9];

            //Acumulado de costos
            diaActual[11] = diaAnterior[11] + diaActual[10];

            //Promedio de costos
            diaActual[12] = Math.Round((diaActual[11] / diaActual[0]), 4);

            return diaActual;
        }

        private static double BuscarCantidadVendida(double rnd, double[,] tablaProbabilidades)
        {
            double cantidadVendida = 0.0;
            for (int i = 0; i < tablaProbabilidades.GetLength(0); i++)
            {
                if (rnd > tablaProbabilidades[i, 1])
                {
                    cantidadVendida = tablaProbabilidades[i, 0];
                }
            }

            return cantidadVendida;
        }
    }
}

