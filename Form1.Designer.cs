namespace Borrador_tp3
{
    partial class CantEjem
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxEstr1 = new System.Windows.Forms.CheckBox();
            this.checkBoxEstr2 = new System.Windows.Forms.CheckBox();
            this.titulo = new System.Windows.Forms.Label();
            this.Estrategia1 = new System.Windows.Forms.Label();
            this.Estrategia2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CostoStockOut = new System.Windows.Forms.Label();
            this.CostoEjemplar = new System.Windows.Forms.Label();
            this.Reembolso = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CantDias = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TituloTabla = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.Estr1Explicada = new System.Windows.Forms.Label();
            this.DatosAdic = new System.Windows.Forms.Label();
            this.Resul1 = new System.Windows.Forms.Label();
            this.Resul2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Subtitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstr1
            // 
            this.checkBoxEstr1.AutoSize = true;
            this.checkBoxEstr1.Location = new System.Drawing.Point(173, 94);
            this.checkBoxEstr1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBoxEstr1.Name = "checkBoxEstr1";
            this.checkBoxEstr1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstr1.TabIndex = 0;
            this.checkBoxEstr1.UseVisualStyleBackColor = true;
            this.checkBoxEstr1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxEstr2
            // 
            this.checkBoxEstr2.AutoSize = true;
            this.checkBoxEstr2.Location = new System.Drawing.Point(173, 138);
            this.checkBoxEstr2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkBoxEstr2.Name = "checkBoxEstr2";
            this.checkBoxEstr2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstr2.TabIndex = 1;
            this.checkBoxEstr2.UseVisualStyleBackColor = true;
            this.checkBoxEstr2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titulo.Location = new System.Drawing.Point(15, 15);
            this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titulo.Name = "titulo";
            this.titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titulo.Size = new System.Drawing.Size(403, 37);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Kiosko de Venta de Diarios";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Estrategia1
            // 
            this.Estrategia1.AutoSize = true;
            this.Estrategia1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estrategia1.Location = new System.Drawing.Point(21, 88);
            this.Estrategia1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Estrategia1.Name = "Estrategia1";
            this.Estrategia1.Size = new System.Drawing.Size(139, 27);
            this.Estrategia1.TabIndex = 3;
            this.Estrategia1.Text = "Estrategia 1";
            this.Estrategia1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Estrategia2
            // 
            this.Estrategia2.AutoSize = true;
            this.Estrategia2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estrategia2.Location = new System.Drawing.Point(21, 130);
            this.Estrategia2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Estrategia2.Name = "Estrategia2";
            this.Estrategia2.Size = new System.Drawing.Size(139, 27);
            this.Estrategia2.TabIndex = 4;
            this.Estrategia2.Text = "Estrategia 2";
            this.Estrategia2.Click += new System.EventHandler(this.Estrategia2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese cantidad fija diaria";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 31);
            this.textBox1.TabIndex = 6;
            // 
            // CostoStockOut
            // 
            this.CostoStockOut.AutoSize = true;
            this.CostoStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoStockOut.Location = new System.Drawing.Point(614, 199);
            this.CostoStockOut.Name = "CostoStockOut";
            this.CostoStockOut.Size = new System.Drawing.Size(281, 16);
            this.CostoStockOut.TabIndex = 8;
            this.CostoStockOut.Text = "Ingrese costo de stock out por ejemplar";
            this.CostoStockOut.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CostoEjemplar
            // 
            this.CostoEjemplar.AutoSize = true;
            this.CostoEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoEjemplar.Location = new System.Drawing.Point(267, 199);
            this.CostoEjemplar.Name = "CostoEjemplar";
            this.CostoEjemplar.Size = new System.Drawing.Size(210, 16);
            this.CostoEjemplar.TabIndex = 9;
            this.CostoEjemplar.Text = "Ingrese el costo por ejemplar";
            // 
            // Reembolso
            // 
            this.Reembolso.AutoSize = true;
            this.Reembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reembolso.Location = new System.Drawing.Point(1034, 199);
            this.Reembolso.Name = "Reembolso";
            this.Reembolso.Size = new System.Drawing.Size(229, 16);
            this.Reembolso.TabIndex = 11;
            this.Reembolso.Text = "Ingrese reembolso por ejemplar";
            this.Reembolso.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 189);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 31);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(901, 189);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 31);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1275, 189);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 31);
            this.textBox4.TabIndex = 14;
            // 
            // CantDias
            // 
            this.CantDias.AutoSize = true;
            this.CantDias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CantDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantDias.Location = new System.Drawing.Point(445, 25);
            this.CantDias.Name = "CantDias";
            this.CantDias.Size = new System.Drawing.Size(551, 24);
            this.CantDias.TabIndex = 15;
            this.CantDias.Text = "Estrategias para los pedidos de ejemplares de un diario X";
            this.CantDias.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(627, 84);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 31);
            this.textBox5.TabIndex = 17;
            // 
            // TituloTabla
            // 
            this.TituloTabla.AutoSize = true;
            this.TituloTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTabla.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TituloTabla.Location = new System.Drawing.Point(739, 248);
            this.TituloTabla.Name = "TituloTabla";
            this.TituloTabla.Size = new System.Drawing.Size(601, 25);
            this.TituloTabla.TabIndex = 18;
            this.TituloTabla.Text = "La siguiente tabla tiene un reloj de 120 dias segun enunciado";
            this.TituloTabla.Click += new System.EventHandler(this.TituloTabla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1317, 221);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Estr1Explicada
            // 
            this.Estr1Explicada.AutoSize = true;
            this.Estr1Explicada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estr1Explicada.Location = new System.Drawing.Point(197, 94);
            this.Estr1Explicada.Name = "Estr1Explicada";
            this.Estr1Explicada.Size = new System.Drawing.Size(271, 18);
            this.Estr1Explicada.TabIndex = 20;
            this.Estr1Explicada.Text = "(Vendidos + stock out) del dia anterior";
            this.Estr1Explicada.Click += new System.EventHandler(this.label2_Click_4);
            // 
            // DatosAdic
            // 
            this.DatosAdic.AutoSize = true;
            this.DatosAdic.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosAdic.Location = new System.Drawing.Point(21, 194);
            this.DatosAdic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DatosAdic.Name = "DatosAdic";
            this.DatosAdic.Size = new System.Drawing.Size(208, 27);
            this.DatosAdic.TabIndex = 21;
            this.DatosAdic.Text = "Datos Adicionales:";
            this.DatosAdic.Click += new System.EventHandler(this.label2_Click_5);
            // 
            // Resul1
            // 
            this.Resul1.AutoSize = true;
            this.Resul1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resul1.Location = new System.Drawing.Point(477, 88);
            this.Resul1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Resul1.Name = "Resul1";
            this.Resul1.Size = new System.Drawing.Size(151, 27);
            this.Resul1.TabIndex = 22;
            this.Resul1.Text = "Resultado E1";
            this.Resul1.Click += new System.EventHandler(this.label2_Click_6);
            // 
            // Resul2
            // 
            this.Resul2.AutoSize = true;
            this.Resul2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resul2.Location = new System.Drawing.Point(477, 128);
            this.Resul2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Resul2.Name = "Resul2";
            this.Resul2.Size = new System.Drawing.Size(151, 27);
            this.Resul2.TabIndex = 23;
            this.Resul2.Text = "Resultado E2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(627, 122);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(91, 31);
            this.textBox6.TabIndex = 24;
            // 
            // Subtitulo
            // 
            this.Subtitulo.AutoSize = true;
            this.Subtitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Subtitulo.Location = new System.Drawing.Point(1017, 12);
            this.Subtitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Subtitulo.Name = "Subtitulo";
            this.Subtitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Subtitulo.Size = new System.Drawing.Size(315, 37);
            this.Subtitulo.TabIndex = 25;
            this.Subtitulo.Text = "Simulador de Costos";
            this.Subtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(21, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tabla de Simulación para la estrategia seleccionada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CantEjem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subtitulo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Resul2);
            this.Controls.Add(this.Resul1);
            this.Controls.Add(this.DatosAdic);
            this.Controls.Add(this.Estr1Explicada);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TituloTabla);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.CantDias);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Reembolso);
            this.Controls.Add(this.CostoEjemplar);
            this.Controls.Add(this.CostoStockOut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estrategia2);
            this.Controls.Add(this.Estrategia1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.checkBoxEstr2);
            this.Controls.Add(this.checkBoxEstr1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CantEjem";
            this.Text = "TP 3 Montecarlo Ejercicio 8 Grupo Q";
            this.Load += new System.EventHandler(this.CantEjem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstr1;
        private System.Windows.Forms.CheckBox checkBoxEstr2;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label Estrategia1;
        private System.Windows.Forms.Label Estrategia2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CostoStockOut;
        private System.Windows.Forms.Label CostoEjemplar;
        private System.Windows.Forms.Label Reembolso;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label CantDias;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label TituloTabla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Estr1Explicada;
        private System.Windows.Forms.Label DatosAdic;
        private System.Windows.Forms.Label Resul1;
        private System.Windows.Forms.Label Resul2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Subtitulo;
        private System.Windows.Forms.Label label3;
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
    }
}

