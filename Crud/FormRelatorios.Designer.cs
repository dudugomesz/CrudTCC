namespace Crud
{
    partial class FormRelatorios
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
            this.dgv_relatorios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_relatorios
            // 
            this.dgv_relatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_relatorios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_relatorios.Location = new System.Drawing.Point(0, 303);
            this.dgv_relatorios.Name = "dgv_relatorios";
            this.dgv_relatorios.RowHeadersWidth = 51;
            this.dgv_relatorios.RowTemplate.Height = 24;
            this.dgv_relatorios.Size = new System.Drawing.Size(932, 300);
            this.dgv_relatorios.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data Inicial";
            // 
            // dataInicio
            // 
            this.dataInicio.Location = new System.Drawing.Point(18, 42);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(203, 22);
            this.dataInicio.TabIndex = 22;
            // 
            // dataFim
            // 
            this.dataFim.Location = new System.Drawing.Point(239, 42);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(204, 22);
            this.dataFim.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Data Final";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(239, 146);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 24);
            this.cmbVendedor.TabIndex = 25;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(18, 146);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Vendedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 230);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 36);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(221, 230);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 36);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Red;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(795, 214);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(110, 36);
            this.btn_voltar.TabIndex = 31;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFim);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_relatorios);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_relatorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn_voltar;
    }
}