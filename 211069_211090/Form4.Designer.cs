namespace _211069_211090
{
    partial class Form4
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Clientes = new System.Windows.Forms.ListView();
            this.listView_Vendas = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_nasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Vendas";
            // 
            // listView_Clientes
            // 
            this.listView_Clientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.cpf,
            this.data_nasc,
            this.email,
            this.telefone,
            this.cidade});
            this.listView_Clientes.HideSelection = false;
            this.listView_Clientes.Location = new System.Drawing.Point(12, 115);
            this.listView_Clientes.Name = "listView_Clientes";
            this.listView_Clientes.Size = new System.Drawing.Size(375, 240);
            this.listView_Clientes.TabIndex = 36;
            this.listView_Clientes.UseCompatibleStateImageBehavior = false;
            this.listView_Clientes.View = System.Windows.Forms.View.Details;
            this.listView_Clientes.SelectedIndexChanged += new System.EventHandler(this.listView_Clientes_SelectedIndexChanged);
            // 
            // listView_Vendas
            // 
            this.listView_Vendas.HideSelection = false;
            this.listView_Vendas.Location = new System.Drawing.Point(425, 115);
            this.listView_Vendas.Name = "listView_Vendas";
            this.listView_Vendas.Size = new System.Drawing.Size(374, 240);
            this.listView_Vendas.TabIndex = 37;
            this.listView_Vendas.UseCompatibleStateImageBehavior = false;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_nasc
            // 
            this.data_nasc.Text = "Data Nasc";
            this.data_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.data_nasc.Width = 70;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidade
            // 
            this.cidade.Text = "Cidade";
            this.cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.listView_Vendas);
            this.Controls.Add(this.listView_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader data_nasc;
        private System.Windows.Forms.ListView listView_Vendas;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.ColumnHeader cidade;
        public System.Windows.Forms.ListView listView_Clientes;
    }
}