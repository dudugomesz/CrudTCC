namespace Crud
{
    partial class FormUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btn_salvar_user = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btn_editar_user = new System.Windows.Forms.Button();
            this.btn_excluir_user = new System.Windows.Forms.Button();
            this.btn_read_user = new System.Windows.Forms.Button();
            this.btn_voltar_Frmuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Perfil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desconto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(127, 22);
            this.txtNome.TabIndex = 6;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(144, 158);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(127, 22);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(144, 195);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(127, 22);
            this.txtSenha.TabIndex = 8;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(166, 272);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(105, 22);
            this.txtDesconto.TabIndex = 10;
            // 
            // btn_salvar_user
            // 
            this.btn_salvar_user.Location = new System.Drawing.Point(144, 374);
            this.btn_salvar_user.Name = "btn_salvar_user";
            this.btn_salvar_user.Size = new System.Drawing.Size(100, 30);
            this.btn_salvar_user.TabIndex = 11;
            this.btn_salvar_user.Text = "Salvar";
            this.btn_salvar_user.UseVisualStyleBackColor = true;
            this.btn_salvar_user.Click += new System.EventHandler(this.btn_salvar_user_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(597, 101);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(365, 328);
            this.dgvUsuarios.TabIndex = 12;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "VENDEDOR",
            "GERENTE",
            "ESTOQUE"});
            this.cmbPerfil.Location = new System.Drawing.Point(144, 234);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 24);
            this.cmbPerfil.TabIndex = 13;
            // 
            // btn_editar_user
            // 
            this.btn_editar_user.Location = new System.Drawing.Point(862, 459);
            this.btn_editar_user.Name = "btn_editar_user";
            this.btn_editar_user.Size = new System.Drawing.Size(100, 30);
            this.btn_editar_user.TabIndex = 14;
            this.btn_editar_user.Text = "Editar";
            this.btn_editar_user.UseVisualStyleBackColor = true;
            this.btn_editar_user.Click += new System.EventHandler(this.btn_editar_user_Click);
            // 
            // btn_excluir_user
            // 
            this.btn_excluir_user.Location = new System.Drawing.Point(728, 459);
            this.btn_excluir_user.Name = "btn_excluir_user";
            this.btn_excluir_user.Size = new System.Drawing.Size(100, 30);
            this.btn_excluir_user.TabIndex = 15;
            this.btn_excluir_user.Text = "Excluir";
            this.btn_excluir_user.UseVisualStyleBackColor = true;
            this.btn_excluir_user.Click += new System.EventHandler(this.btn_excluir_user_Click);
            // 
            // btn_read_user
            // 
            this.btn_read_user.Location = new System.Drawing.Point(606, 459);
            this.btn_read_user.Name = "btn_read_user";
            this.btn_read_user.Size = new System.Drawing.Size(100, 30);
            this.btn_read_user.TabIndex = 16;
            this.btn_read_user.Text = "Carregar";
            this.btn_read_user.UseVisualStyleBackColor = true;
            this.btn_read_user.Click += new System.EventHandler(this.btn_read_user_Click);
            // 
            // btn_voltar_Frmuser
            // 
            this.btn_voltar_Frmuser.Location = new System.Drawing.Point(25, 473);
            this.btn_voltar_Frmuser.Name = "btn_voltar_Frmuser";
            this.btn_voltar_Frmuser.Size = new System.Drawing.Size(100, 30);
            this.btn_voltar_Frmuser.TabIndex = 17;
            this.btn_voltar_Frmuser.Text = "Voltar";
            this.btn_voltar_Frmuser.UseVisualStyleBackColor = true;
            this.btn_voltar_Frmuser.Click += new System.EventHandler(this.btn_voltar_Frmuser_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 515);
            this.Controls.Add(this.btn_voltar_Frmuser);
            this.Controls.Add(this.btn_read_user);
            this.Controls.Add(this.btn_excluir_user);
            this.Controls.Add(this.btn_editar_user);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btn_salvar_user);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button btn_salvar_user;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Button btn_editar_user;
        private System.Windows.Forms.Button btn_excluir_user;
        private System.Windows.Forms.Button btn_read_user;
        private System.Windows.Forms.Button btn_voltar_Frmuser;
    }
}