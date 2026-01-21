namespace Crud
{
    partial class pecas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome_pecas = new System.Windows.Forms.TextBox();
            this.txtDescricao_pecas = new System.Windows.Forms.TextBox();
            this.txtPreco_pecas = new System.Windows.Forms.TextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.DgvPecas = new System.Windows.Forms.DataGridView();
            this.btn_salvar_pecas = new System.Windows.Forms.Button();
            this.btn_read_pecas = new System.Windows.Forms.Button();
            this.btn_excluir_pecas = new System.Windows.Forms.Button();
            this.btn_editar_pecas = new System.Windows.Forms.Button();
            this.btn_pecas_inativas = new System.Windows.Forms.Button();
            this.btnReativar_peca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fornecedor";
            // 
            // txtNome_pecas
            // 
            this.txtNome_pecas.Location = new System.Drawing.Point(220, 65);
            this.txtNome_pecas.Name = "txtNome_pecas";
            this.txtNome_pecas.Size = new System.Drawing.Size(127, 22);
            this.txtNome_pecas.TabIndex = 7;
            // 
            // txtDescricao_pecas
            // 
            this.txtDescricao_pecas.Location = new System.Drawing.Point(245, 121);
            this.txtDescricao_pecas.Name = "txtDescricao_pecas";
            this.txtDescricao_pecas.Size = new System.Drawing.Size(127, 22);
            this.txtDescricao_pecas.TabIndex = 8;
            // 
            // txtPreco_pecas
            // 
            this.txtPreco_pecas.Location = new System.Drawing.Point(235, 174);
            this.txtPreco_pecas.Name = "txtPreco_pecas";
            this.txtPreco_pecas.Size = new System.Drawing.Size(127, 22);
            this.txtPreco_pecas.TabIndex = 9;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(268, 219);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 24);
            this.cmbFornecedor.TabIndex = 10;
            // 
            // DgvPecas
            // 
            this.DgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPecas.Location = new System.Drawing.Point(422, 24);
            this.DgvPecas.Name = "DgvPecas";
            this.DgvPecas.RowHeadersWidth = 51;
            this.DgvPecas.RowTemplate.Height = 24;
            this.DgvPecas.Size = new System.Drawing.Size(482, 320);
            this.DgvPecas.TabIndex = 11;
            this.DgvPecas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPecas_CellClick);
            // 
            // btn_salvar_pecas
            // 
            this.btn_salvar_pecas.Location = new System.Drawing.Point(164, 314);
            this.btn_salvar_pecas.Name = "btn_salvar_pecas";
            this.btn_salvar_pecas.Size = new System.Drawing.Size(100, 30);
            this.btn_salvar_pecas.TabIndex = 12;
            this.btn_salvar_pecas.Text = "Salvar";
            this.btn_salvar_pecas.UseVisualStyleBackColor = true;
            this.btn_salvar_pecas.Click += new System.EventHandler(this.btn_salvar_pecas_Click);
            // 
            // btn_read_pecas
            // 
            this.btn_read_pecas.Location = new System.Drawing.Point(439, 391);
            this.btn_read_pecas.Name = "btn_read_pecas";
            this.btn_read_pecas.Size = new System.Drawing.Size(142, 30);
            this.btn_read_pecas.TabIndex = 19;
            this.btn_read_pecas.Text = "Carregar";
            this.btn_read_pecas.UseVisualStyleBackColor = true;
            this.btn_read_pecas.Click += new System.EventHandler(this.btn_read_pecas_Click);
            // 
            // btn_excluir_pecas
            // 
            this.btn_excluir_pecas.Location = new System.Drawing.Point(603, 391);
            this.btn_excluir_pecas.Name = "btn_excluir_pecas";
            this.btn_excluir_pecas.Size = new System.Drawing.Size(142, 30);
            this.btn_excluir_pecas.TabIndex = 18;
            this.btn_excluir_pecas.Text = "Excluir";
            this.btn_excluir_pecas.UseVisualStyleBackColor = true;
            this.btn_excluir_pecas.Click += new System.EventHandler(this.btn_excluir_pecas_Click);
            // 
            // btn_editar_pecas
            // 
            this.btn_editar_pecas.Location = new System.Drawing.Point(762, 391);
            this.btn_editar_pecas.Name = "btn_editar_pecas";
            this.btn_editar_pecas.Size = new System.Drawing.Size(142, 30);
            this.btn_editar_pecas.TabIndex = 17;
            this.btn_editar_pecas.Text = "Editar";
            this.btn_editar_pecas.UseVisualStyleBackColor = true;
            this.btn_editar_pecas.Click += new System.EventHandler(this.btn_editar_pecas_Click);
            // 
            // btn_pecas_inativas
            // 
            this.btn_pecas_inativas.Location = new System.Drawing.Point(716, 474);
            this.btn_pecas_inativas.Name = "btn_pecas_inativas";
            this.btn_pecas_inativas.Size = new System.Drawing.Size(142, 30);
            this.btn_pecas_inativas.TabIndex = 20;
            this.btn_pecas_inativas.Text = "Mostrar peças inativas";
            this.btn_pecas_inativas.UseVisualStyleBackColor = true;
            this.btn_pecas_inativas.Click += new System.EventHandler(this.btn_pecas_inativas_Click);
            // 
            // btnReativar_peca
            // 
            this.btnReativar_peca.Location = new System.Drawing.Point(497, 474);
            this.btnReativar_peca.Name = "btnReativar_peca";
            this.btnReativar_peca.Size = new System.Drawing.Size(142, 30);
            this.btnReativar_peca.TabIndex = 21;
            this.btnReativar_peca.Text = "Reativar peça";
            this.btnReativar_peca.UseVisualStyleBackColor = true;
            this.btnReativar_peca.Click += new System.EventHandler(this.btnReativar_peca_Click);
            // 
            // pecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btnReativar_peca);
            this.Controls.Add(this.btn_pecas_inativas);
            this.Controls.Add(this.btn_read_pecas);
            this.Controls.Add(this.btn_excluir_pecas);
            this.Controls.Add(this.btn_editar_pecas);
            this.Controls.Add(this.btn_salvar_pecas);
            this.Controls.Add(this.DgvPecas);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtPreco_pecas);
            this.Controls.Add(this.txtDescricao_pecas);
            this.Controls.Add(this.txtNome_pecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "pecas";
            this.Text = "Estoque de Peças";
            this.Load += new System.EventHandler(this.pecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome_pecas;
        private System.Windows.Forms.TextBox txtDescricao_pecas;
        private System.Windows.Forms.TextBox txtPreco_pecas;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.DataGridView DgvPecas;
        private System.Windows.Forms.Button btn_salvar_pecas;
        private System.Windows.Forms.Button btn_read_pecas;
        private System.Windows.Forms.Button btn_excluir_pecas;
        private System.Windows.Forms.Button btn_editar_pecas;
        private System.Windows.Forms.Button btn_pecas_inativas;
        private System.Windows.Forms.Button btnReativar_peca;
    }
}