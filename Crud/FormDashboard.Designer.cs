namespace Crud
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_gerarRelatorio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartVendedor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopPecas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVendasMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasMes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_gerarRelatorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtFim);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(983, 28);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(119, 38);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "até";
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(251, 32);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(107, 22);
            this.dtFim.TabIndex = 27;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(97, 32);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(107, 22);
            this.dtInicio.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Período:";
            // 
            // btn_gerarRelatorio
            // 
            this.btn_gerarRelatorio.Location = new System.Drawing.Point(416, 26);
            this.btn_gerarRelatorio.Name = "btn_gerarRelatorio";
            this.btn_gerarRelatorio.Size = new System.Drawing.Size(119, 38);
            this.btn_gerarRelatorio.TabIndex = 29;
            this.btn_gerarRelatorio.Text = "Gerar Relatório";
            this.btn_gerarRelatorio.UseVisualStyleBackColor = true;
            this.btn_gerarRelatorio.Click += new System.EventHandler(this.btn_gerarRelatorio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 100);
            this.panel2.TabIndex = 7;
            // 
            // chartVendedor
            // 
            chartArea7.Name = "ChartArea1";
            this.chartVendedor.ChartAreas.Add(chartArea7);
            this.tableLayoutPanel1.SetColumnSpan(this.chartVendedor, 2);
            legend7.Name = "Legend1";
            this.chartVendedor.Legends.Add(legend7);
            this.chartVendedor.Location = new System.Drawing.Point(3, 204);
            this.chartVendedor.Name = "chartVendedor";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartVendedor.Series.Add(series7);
            this.chartVendedor.Size = new System.Drawing.Size(1151, 196);
            this.chartVendedor.TabIndex = 1;
            this.chartVendedor.Text = "chart1";
            // 
            // chartTopPecas
            // 
            chartArea8.Name = "ChartArea1";
            this.chartTopPecas.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartTopPecas.Legends.Add(legend8);
            this.chartTopPecas.Location = new System.Drawing.Point(581, 3);
            this.chartTopPecas.Name = "chartTopPecas";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartTopPecas.Series.Add(series8);
            this.chartTopPecas.Size = new System.Drawing.Size(573, 195);
            this.chartTopPecas.TabIndex = 2;
            this.chartTopPecas.Text = "chart1";
            // 
            // chartVendasMes
            // 
            chartArea9.Name = "ChartArea1";
            this.chartVendasMes.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartVendasMes.Legends.Add(legend9);
            this.chartVendasMes.Location = new System.Drawing.Point(3, 3);
            this.chartVendasMes.Name = "chartVendasMes";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartVendasMes.Series.Add(series9);
            this.chartVendasMes.Size = new System.Drawing.Size(572, 195);
            this.chartVendasMes.TabIndex = 0;
            this.chartVendasMes.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartVendedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartTopPecas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartVendasMes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 403);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasMes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_gerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopPecas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendasMes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}