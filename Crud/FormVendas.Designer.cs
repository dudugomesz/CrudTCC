namespace Crud
{
    partial class FormVendas
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
            this.cmbPeca = new System.Windows.Forms.ComboBox();
            this.txtDesconto_vendas = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco_venda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvITENS = new System.Windows.Forms.DataGridView();
            this.btn_add_venda = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvITENS)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPeca
            // 
            this.cmbPeca.FormattingEnabled = true;
            this.cmbPeca.Location = new System.Drawing.Point(197, 108);
            this.cmbPeca.Name = "cmbPeca";
            this.cmbPeca.Size = new System.Drawing.Size(142, 24);
            this.cmbPeca.TabIndex = 18;
            // 
            // txtDesconto_vendas
            // 
            this.txtDesconto_vendas.Location = new System.Drawing.Point(212, 261);
            this.txtDesconto_vendas.Name = "txtDesconto_vendas";
            this.txtDesconto_vendas.Size = new System.Drawing.Size(127, 22);
            this.txtDesconto_vendas.TabIndex = 17;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(231, 208);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(127, 22);
            this.txtQuantidade.TabIndex = 16;
            // 
            // txtPreco_venda
            // 
            this.txtPreco_venda.Location = new System.Drawing.Point(197, 152);
            this.txtPreco_venda.Name = "txtPreco_venda";
            this.txtPreco_venda.Size = new System.Drawing.Size(142, 22);
            this.txtPreco_venda.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 308);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 22);
            this.txtTotal.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Peça";
            // 
            // DgvITENS
            // 
            this.DgvITENS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvITENS.Location = new System.Drawing.Point(449, 95);
            this.DgvITENS.Name = "DgvITENS";
            this.DgvITENS.RowHeadersWidth = 51;
            this.DgvITENS.RowTemplate.Height = 24;
            this.DgvITENS.Size = new System.Drawing.Size(433, 261);
            this.DgvITENS.TabIndex = 21;
            // 
            // btn_add_venda
            // 
            this.btn_add_venda.Location = new System.Drawing.Point(178, 360);
            this.btn_add_venda.Name = "btn_add_venda";
            this.btn_add_venda.Size = new System.Drawing.Size(100, 30);
            this.btn_add_venda.TabIndex = 22;
            this.btn_add_venda.Text = "Adicionar";
            this.btn_add_venda.UseVisualStyleBackColor = true;
            this.btn_add_venda.Click += new System.EventHandler(this.btn_add_venda_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(467, 385);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(100, 30);
            this.btn_finalizar.TabIndex = 23;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(602, 385);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 30);
            this.btn_remover.TabIndex = 24;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(747, 385);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 30);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_add_venda);
            this.Controls.Add(this.DgvITENS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbPeca);
            this.Controls.Add(this.txtDesconto_vendas);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco_venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvITENS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPeca;
        private System.Windows.Forms.TextBox txtDesconto_vendas;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvITENS;
        private System.Windows.Forms.Button btn_add_venda;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_cancelar;
    }
}