namespace Crud
{
    partial class FormFornecedores
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtNome_Fornecedores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_excluir_fornecedor = new System.Windows.Forms.Button();
            this.btn_editar_fornecedor = new System.Windows.Forms.Button();
            this.btn_salvar_fornecedor = new System.Windows.Forms.Button();
            this.DgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btn_read_fornecedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(217, 189);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 22);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(202, 136);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(127, 22);
            this.txtCNPJ.TabIndex = 14;
            // 
            // txtNome_Fornecedores
            // 
            this.txtNome_Fornecedores.Location = new System.Drawing.Point(202, 80);
            this.txtNome_Fornecedores.Name = "txtNome_Fornecedores";
            this.txtNome_Fornecedores.Size = new System.Drawing.Size(127, 22);
            this.txtNome_Fornecedores.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(217, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(217, 288);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(127, 22);
            this.txtEndereço.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Endereço";
            // 
            // btn_excluir_fornecedor
            // 
            this.btn_excluir_fornecedor.Location = new System.Drawing.Point(636, 386);
            this.btn_excluir_fornecedor.Name = "btn_excluir_fornecedor";
            this.btn_excluir_fornecedor.Size = new System.Drawing.Size(100, 30);
            this.btn_excluir_fornecedor.TabIndex = 21;
            this.btn_excluir_fornecedor.Text = "Excluir";
            this.btn_excluir_fornecedor.UseVisualStyleBackColor = true;
            this.btn_excluir_fornecedor.Click += new System.EventHandler(this.btn_excluir_fornecedor_Click);
            // 
            // btn_editar_fornecedor
            // 
            this.btn_editar_fornecedor.Location = new System.Drawing.Point(772, 386);
            this.btn_editar_fornecedor.Name = "btn_editar_fornecedor";
            this.btn_editar_fornecedor.Size = new System.Drawing.Size(100, 30);
            this.btn_editar_fornecedor.TabIndex = 20;
            this.btn_editar_fornecedor.Text = "Editar";
            this.btn_editar_fornecedor.UseVisualStyleBackColor = true;
            this.btn_editar_fornecedor.Click += new System.EventHandler(this.btn_editar_fornecedor_Click);
            // 
            // btn_salvar_fornecedor
            // 
            this.btn_salvar_fornecedor.Location = new System.Drawing.Point(189, 377);
            this.btn_salvar_fornecedor.Name = "btn_salvar_fornecedor";
            this.btn_salvar_fornecedor.Size = new System.Drawing.Size(100, 30);
            this.btn_salvar_fornecedor.TabIndex = 23;
            this.btn_salvar_fornecedor.Text = "Salvar";
            this.btn_salvar_fornecedor.UseVisualStyleBackColor = true;
            this.btn_salvar_fornecedor.Click += new System.EventHandler(this.btn_salvar_fornecedor_Click);
            // 
            // DgvFornecedores
            // 
            this.DgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFornecedores.Location = new System.Drawing.Point(522, 56);
            this.DgvFornecedores.Name = "DgvFornecedores";
            this.DgvFornecedores.RowHeadersWidth = 51;
            this.DgvFornecedores.RowTemplate.Height = 24;
            this.DgvFornecedores.Size = new System.Drawing.Size(350, 232);
            this.DgvFornecedores.TabIndex = 24;
            this.DgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedores_CellClick);
            // 
            // btn_read_fornecedores
            // 
            this.btn_read_fornecedores.Location = new System.Drawing.Point(501, 386);
            this.btn_read_fornecedores.Name = "btn_read_fornecedores";
            this.btn_read_fornecedores.Size = new System.Drawing.Size(100, 30);
            this.btn_read_fornecedores.TabIndex = 22;
            this.btn_read_fornecedores.Text = "Carregar";
            this.btn_read_fornecedores.UseVisualStyleBackColor = true;
            this.btn_read_fornecedores.Click += new System.EventHandler(this.btn_read_fornecedores_Click);
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.DgvFornecedores);
            this.Controls.Add(this.btn_salvar_fornecedor);
            this.Controls.Add(this.btn_read_fornecedores);
            this.Controls.Add(this.btn_excluir_fornecedor);
            this.Controls.Add(this.btn_editar_fornecedor);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtNome_Fornecedores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormFornecedores";
            this.Text = "FormFornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtNome_Fornecedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir_fornecedor;
        private System.Windows.Forms.Button btn_editar_fornecedor;
        private System.Windows.Forms.Button btn_salvar_fornecedor;
        private System.Windows.Forms.DataGridView DgvFornecedores;
        private System.Windows.Forms.Button btn_read_fornecedores;
    }
}