namespace Crud
{
    partial class Menu_principal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.btn_pecas = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(21, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Location = new System.Drawing.Point(243, 175);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(122, 54);
            this.btn_usuarios.TabIndex = 3;
            this.btn_usuarios.Text = "Usuários";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.Location = new System.Drawing.Point(384, 175);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(122, 54);
            this.btn_fornecedor.TabIndex = 4;
            this.btn_fornecedor.Text = "Fornecedores";
            this.btn_fornecedor.UseVisualStyleBackColor = true;
            this.btn_fornecedor.Click += new System.EventHandler(this.btn_fornecedor_Click);
            // 
            // btn_pecas
            // 
            this.btn_pecas.Location = new System.Drawing.Point(524, 175);
            this.btn_pecas.Name = "btn_pecas";
            this.btn_pecas.Size = new System.Drawing.Size(122, 54);
            this.btn_pecas.TabIndex = 5;
            this.btn_pecas.Text = "Peças";
            this.btn_pecas.UseVisualStyleBackColor = true;
            this.btn_pecas.Click += new System.EventHandler(this.btn_pecas_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Location = new System.Drawing.Point(243, 270);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(122, 54);
            this.btn_vendas.TabIndex = 6;
            this.btn_vendas.Text = "Vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Location = new System.Drawing.Point(384, 270);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(122, 54);
            this.btn_relatorios.TabIndex = 8;
            this.btn_relatorios.Text = "Relatórios";
            this.btn_relatorios.UseVisualStyleBackColor = true;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(21, 49);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(59, 20);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sistema de Gestão de Autopeças";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(384, 436);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(122, 51);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Location = new System.Drawing.Point(524, 270);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(122, 54);
            this.btn_dashboard.TabIndex = 12;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_relatorios);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_pecas);
            this.Controls.Add(this.btn_fornecedor);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Menu_principal";
            this.Text = "Menu_principal";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.Button btn_pecas;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dashboard;
    }
}