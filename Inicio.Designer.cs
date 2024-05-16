namespace Borrador_tp3
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultadoE2 = new System.Windows.Forms.TextBox();
            this.Resul2 = new System.Windows.Forms.Label();
            this.Resul1 = new System.Windows.Forms.Label();
            this.DatosAdic = new System.Windows.Forms.Label();
            this.Estr1Explicada = new System.Windows.Forms.Label();
            this.grdTablaMontecarlo = new System.Windows.Forms.DataGridView();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reembolsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoSiguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoStoOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reembolsos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumuladorCostos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioCostos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloTabla = new System.Windows.Forms.Label();
            this.txtResultadoE1 = new System.Windows.Forms.TextBox();
            this.CantDias = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.CostoEjemplar = new System.Windows.Forms.Label();
            this.CostoStockOut = new System.Windows.Forms.Label();
            this.txtCantidadFija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labele2 = new System.Windows.Forms.Label();
            this.labelE1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.ckE2 = new System.Windows.Forms.CheckBox();
            this.ckE1 = new System.Windows.Forms.CheckBox();
            this.txtCostoStockOut = new System.Windows.Forms.TextBox();
            this.txtReembolso = new System.Windows.Forms.TextBox();
            this.Reembolso = new System.Windows.Forms.Label();
            this.Subtitulo = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnLimpiarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTablaMontecarlo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tabla de Simulación para la estrategia seleccionada";
            // 
            // txtResultadoE2
            // 
            this.txtResultadoE2.Location = new System.Drawing.Point(621, 125);
            this.txtResultadoE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultadoE2.Name = "txtResultadoE2";
            this.txtResultadoE2.Size = new System.Drawing.Size(91, 20);
            this.txtResultadoE2.TabIndex = 45;
            // 
            // Resul2
            // 
            this.Resul2.AutoSize = true;
            this.Resul2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resul2.Location = new System.Drawing.Point(471, 121);
            this.Resul2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Resul2.Name = "Resul2";
            this.Resul2.Size = new System.Drawing.Size(151, 27);
            this.Resul2.TabIndex = 44;
            this.Resul2.Text = "Resultado E2";
            // 
            // Resul1
            // 
            this.Resul1.AutoSize = true;
            this.Resul1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resul1.Location = new System.Drawing.Point(471, 81);
            this.Resul1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Resul1.Name = "Resul1";
            this.Resul1.Size = new System.Drawing.Size(151, 27);
            this.Resul1.TabIndex = 43;
            this.Resul1.Text = "Resultado E1";
            // 
            // DatosAdic
            // 
            this.DatosAdic.AutoSize = true;
            this.DatosAdic.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosAdic.Location = new System.Drawing.Point(15, 187);
            this.DatosAdic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DatosAdic.Name = "DatosAdic";
            this.DatosAdic.Size = new System.Drawing.Size(208, 27);
            this.DatosAdic.TabIndex = 42;
            this.DatosAdic.Text = "Datos Adicionales:";
            // 
            // Estr1Explicada
            // 
            this.Estr1Explicada.AutoSize = true;
            this.Estr1Explicada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estr1Explicada.Location = new System.Drawing.Point(191, 87);
            this.Estr1Explicada.Name = "Estr1Explicada";
            this.Estr1Explicada.Size = new System.Drawing.Size(271, 18);
            this.Estr1Explicada.TabIndex = 41;
            this.Estr1Explicada.Text = "(Vendidos + stock out) del dia anterior";
            // 
            // grdTablaMontecarlo
            // 
            this.grdTablaMontecarlo.AllowUserToOrderColumns = true;
            this.grdTablaMontecarlo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdTablaMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTablaMontecarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dias,
            this.StockDia,
            this.RND,
            this.CantVendida,
            this.Reembolsado,
            this.SockOut,
            this.PedidoSiguiente,
            this.CostoVendidos,
            this.CostoStoOut,
            this.Reembolsos,
            this.TotalCostoDiario,
            this.AcumuladorCostos,
            this.PromedioCostos});
            this.grdTablaMontecarlo.Location = new System.Drawing.Point(15, 283);
            this.grdTablaMontecarlo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTablaMontecarlo.Name = "grdTablaMontecarlo";
            this.grdTablaMontecarlo.Size = new System.Drawing.Size(1317, 455);
            this.grdTablaMontecarlo.TabIndex = 40;
            // 
            // Dias
            // 
            this.Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dias.HeaderText = "Reloj en Días";
            this.Dias.Name = "Dias";
            this.Dias.Width = 95;
            // 
            // StockDia
            // 
            this.StockDia.HeaderText = "Stock del Día";
            this.StockDia.Name = "StockDia";
            this.StockDia.Width = 95;
            // 
            // RND
            // 
            this.RND.HeaderText = "RND Demanda";
            this.RND.Name = "RND";
            this.RND.Width = 95;
            // 
            // CantVendida
            // 
            this.CantVendida.HeaderText = "Cantidad Vendida";
            this.CantVendida.Name = "CantVendida";
            this.CantVendida.Width = 95;
            // 
            // Reembolsado
            // 
            this.Reembolsado.HeaderText = "Para Reembolso";
            this.Reembolsado.Name = "Reembolsado";
            // 
            // SockOut
            // 
            this.SockOut.HeaderText = "Stock Out";
            this.SockOut.Name = "SockOut";
            // 
            // PedidoSiguiente
            // 
            this.PedidoSiguiente.HeaderText = "Pedido p/ dia sig";
            this.PedidoSiguiente.Name = "PedidoSiguiente";
            // 
            // CostoVendidos
            // 
            this.CostoVendidos.HeaderText = "Costo Ej Vendidos";
            this.CostoVendidos.Name = "CostoVendidos";
            // 
            // CostoStoOut
            // 
            this.CostoStoOut.HeaderText = "Costo por Stock Out";
            this.CostoStoOut.Name = "CostoStoOut";
            // 
            // Reembolsos
            // 
            this.Reembolsos.HeaderText = "Ganancia p/ Reembolso";
            this.Reembolsos.Name = "Reembolsos";
            // 
            // TotalCostoDiario
            // 
            this.TotalCostoDiario.HeaderText = "Total Costo Diario";
            this.TotalCostoDiario.Name = "TotalCostoDiario";
            // 
            // AcumuladorCostos
            // 
            this.AcumuladorCostos.HeaderText = "Acumulador Costos";
            this.AcumuladorCostos.Name = "AcumuladorCostos";
            this.AcumuladorCostos.Width = 95;
            // 
            // PromedioCostos
            // 
            this.PromedioCostos.HeaderText = "Promedio de Costos";
            this.PromedioCostos.Name = "PromedioCostos";
            this.PromedioCostos.Width = 95;
            // 
            // TituloTabla
            // 
            this.TituloTabla.AutoSize = true;
            this.TituloTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTabla.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TituloTabla.Location = new System.Drawing.Point(733, 241);
            this.TituloTabla.Name = "TituloTabla";
            this.TituloTabla.Size = new System.Drawing.Size(601, 25);
            this.TituloTabla.TabIndex = 39;
            this.TituloTabla.Text = "La siguiente tabla tiene un reloj de 120 dias segun enunciado";
            // 
            // txtResultadoE1
            // 
            this.txtResultadoE1.Location = new System.Drawing.Point(621, 88);
            this.txtResultadoE1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultadoE1.Name = "txtResultadoE1";
            this.txtResultadoE1.Size = new System.Drawing.Size(91, 20);
            this.txtResultadoE1.TabIndex = 38;
            // 
            // CantDias
            // 
            this.CantDias.AutoSize = true;
            this.CantDias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantDias.Location = new System.Drawing.Point(439, 18);
            this.CantDias.Name = "CantDias";
            this.CantDias.Size = new System.Drawing.Size(551, 24);
            this.CantDias.TabIndex = 37;
            this.CantDias.Text = "Estrategias para los pedidos de ejemplares de un diario X";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(476, 191);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(64, 20);
            this.txtCostoUnitario.TabIndex = 36;
            // 
            // CostoEjemplar
            // 
            this.CostoEjemplar.AutoSize = true;
            this.CostoEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoEjemplar.Location = new System.Drawing.Point(261, 192);
            this.CostoEjemplar.Name = "CostoEjemplar";
            this.CostoEjemplar.Size = new System.Drawing.Size(210, 16);
            this.CostoEjemplar.TabIndex = 35;
            this.CostoEjemplar.Text = "Ingrese el costo por ejemplar";
            // 
            // CostoStockOut
            // 
            this.CostoStockOut.AutoSize = true;
            this.CostoStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoStockOut.Location = new System.Drawing.Point(608, 192);
            this.CostoStockOut.Name = "CostoStockOut";
            this.CostoStockOut.Size = new System.Drawing.Size(281, 16);
            this.CostoStockOut.TabIndex = 34;
            this.CostoStockOut.Text = "Ingrese costo de stock out por ejemplar";
            // 
            // txtCantidadFija
            // 
            this.txtCantidadFija.Location = new System.Drawing.Point(388, 126);
            this.txtCantidadFija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadFija.Name = "txtCantidadFija";
            this.txtCantidadFija.Size = new System.Drawing.Size(64, 20);
            this.txtCantidadFija.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese cantidad fija diaria";
            // 
            // labele2
            // 
            this.labele2.AutoSize = true;
            this.labele2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labele2.Location = new System.Drawing.Point(15, 123);
            this.labele2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labele2.Name = "labele2";
            this.labele2.Size = new System.Drawing.Size(139, 27);
            this.labele2.TabIndex = 31;
            this.labele2.Text = "Estrategia 2";
            // 
            // labelE1
            // 
            this.labelE1.AutoSize = true;
            this.labelE1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE1.Location = new System.Drawing.Point(15, 81);
            this.labelE1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelE1.Name = "labelE1";
            this.labelE1.Size = new System.Drawing.Size(139, 27);
            this.labelE1.TabIndex = 30;
            this.labelE1.Text = "Estrategia 1";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titulo.Location = new System.Drawing.Point(9, 8);
            this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titulo.Name = "titulo";
            this.titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titulo.Size = new System.Drawing.Size(403, 37);
            this.titulo.TabIndex = 29;
            this.titulo.Text = "Kiosko de Venta de Diarios";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckE2
            // 
            this.ckE2.AutoSize = true;
            this.ckE2.Location = new System.Drawing.Point(167, 131);
            this.ckE2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ckE2.Name = "ckE2";
            this.ckE2.Size = new System.Drawing.Size(15, 14);
            this.ckE2.TabIndex = 28;
            this.ckE2.UseVisualStyleBackColor = true;
            // 
            // ckE1
            // 
            this.ckE1.AutoSize = true;
            this.ckE1.Location = new System.Drawing.Point(167, 87);
            this.ckE1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ckE1.Name = "ckE1";
            this.ckE1.Size = new System.Drawing.Size(15, 14);
            this.ckE1.TabIndex = 27;
            this.ckE1.UseVisualStyleBackColor = true;
            // 
            // txtCostoStockOut
            // 
            this.txtCostoStockOut.Location = new System.Drawing.Point(895, 194);
            this.txtCostoStockOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoStockOut.Name = "txtCostoStockOut";
            this.txtCostoStockOut.Size = new System.Drawing.Size(64, 20);
            this.txtCostoStockOut.TabIndex = 47;
            // 
            // txtReembolso
            // 
            this.txtReembolso.Location = new System.Drawing.Point(1238, 197);
            this.txtReembolso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReembolso.Name = "txtReembolso";
            this.txtReembolso.Size = new System.Drawing.Size(64, 20);
            this.txtReembolso.TabIndex = 49;
            // 
            // Reembolso
            // 
            this.Reembolso.AutoSize = true;
            this.Reembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reembolso.Location = new System.Drawing.Point(1003, 198);
            this.Reembolso.Name = "Reembolso";
            this.Reembolso.Size = new System.Drawing.Size(229, 16);
            this.Reembolso.TabIndex = 48;
            this.Reembolso.Text = "Ingrese reembolso por ejemplar";
            // 
            // Subtitulo
            // 
            this.Subtitulo.AutoSize = true;
            this.Subtitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Subtitulo.Location = new System.Drawing.Point(1026, 8);
            this.Subtitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Subtitulo.Name = "Subtitulo";
            this.Subtitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Subtitulo.Size = new System.Drawing.Size(315, 37);
            this.Subtitulo.TabIndex = 50;
            this.Subtitulo.Text = "Simulador de Costos";
            this.Subtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(883, 81);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(134, 62);
            this.btnInicio.TabIndex = 51;
            this.btnInicio.Text = "Iniciar Simulacion";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnLimpiarTabla
            // 
            this.btnLimpiarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTabla.Location = new System.Drawing.Point(1039, 81);
            this.btnLimpiarTabla.Name = "btnLimpiarTabla";
            this.btnLimpiarTabla.Size = new System.Drawing.Size(108, 62);
            this.btnLimpiarTabla.TabIndex = 52;
            this.btnLimpiarTabla.Text = "LIMPIAR TABLA";
            this.btnLimpiarTabla.UseVisualStyleBackColor = true;
            this.btnLimpiarTabla.Click += new System.EventHandler(this.btnLimpiarTabla_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 749);
            this.Controls.Add(this.btnLimpiarTabla);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.Subtitulo);
            this.Controls.Add(this.txtReembolso);
            this.Controls.Add(this.Reembolso);
            this.Controls.Add(this.txtCostoStockOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultadoE2);
            this.Controls.Add(this.Resul2);
            this.Controls.Add(this.Resul1);
            this.Controls.Add(this.DatosAdic);
            this.Controls.Add(this.Estr1Explicada);
            this.Controls.Add(this.grdTablaMontecarlo);
            this.Controls.Add(this.TituloTabla);
            this.Controls.Add(this.txtResultadoE1);
            this.Controls.Add(this.CantDias);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.CostoEjemplar);
            this.Controls.Add(this.CostoStockOut);
            this.Controls.Add(this.txtCantidadFija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labele2);
            this.Controls.Add(this.labelE1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.ckE2);
            this.Controls.Add(this.ckE1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTablaMontecarlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultadoE2;
        private System.Windows.Forms.Label Resul2;
        private System.Windows.Forms.Label Resul1;
        private System.Windows.Forms.Label DatosAdic;
        private System.Windows.Forms.Label Estr1Explicada;
        private System.Windows.Forms.DataGridView grdTablaMontecarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reembolsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoSiguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoStoOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reembolsos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumuladorCostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioCostos;
        private System.Windows.Forms.Label TituloTabla;
        private System.Windows.Forms.TextBox txtResultadoE1;
        private System.Windows.Forms.Label CantDias;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label CostoEjemplar;
        private System.Windows.Forms.Label CostoStockOut;
        private System.Windows.Forms.TextBox txtCantidadFija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labele2;
        private System.Windows.Forms.Label labelE1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.CheckBox ckE2;
        private System.Windows.Forms.CheckBox ckE1;
        private System.Windows.Forms.TextBox txtCostoStockOut;
        private System.Windows.Forms.TextBox txtReembolso;
        private System.Windows.Forms.Label Reembolso;
        private System.Windows.Forms.Label Subtitulo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnLimpiarTabla;
    }
}