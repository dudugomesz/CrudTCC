namespace Crud
{
    partial class FormStatusPedido
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
            this.dgv_statusPedidos = new System.Windows.Forms.DataGridView();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statusPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_statusPedidos
            // 
            this.dgv_statusPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_statusPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_statusPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgv_statusPedidos.Name = "dgv_statusPedidos";
            this.dgv_statusPedidos.RowHeadersWidth = 51;
            this.dgv_statusPedidos.RowTemplate.Height = 24;
            this.dgv_statusPedidos.Size = new System.Drawing.Size(1029, 301);
            this.dgv_statusPedidos.TabIndex = 0;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(428, 390);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(160, 44);
            this.btn_Filtrar.TabIndex = 1;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 434);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(132, 40);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(428, 349);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 24);
            this.cbStatus.TabIndex = 3;
            // 
            // FormStatusPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 515);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.dgv_statusPedidos);
            this.Name = "FormStatusPedido";
            this.Text = "Status do Pedido";
            this.Load += new System.EventHandler(this.FormStatusPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statusPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_statusPedidos;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}