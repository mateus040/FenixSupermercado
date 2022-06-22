using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211069_211090
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            int cpf = int.Parse(txt_cpf.Text);
            int data = int.Parse(txt_data.Text);
            string email = txt_email.Text;
            int telefone = int.Parse(txt_telefone.Text);
            string cidade = txt_cidade.Text;


            ListViewItem clientes = new ListViewItem(txt_nome.Text);
            clientes.SubItems.Add(txt_cpf.Text);
            clientes.SubItems.Add(txt_data.Text);
            clientes.SubItems.Add(txt_email.Text);
            clientes.SubItems.Add(txt_telefone.Text);
            clientes.SubItems.Add(txt_cidade.Text);
            listView_Clientes.Items.Add(clientes);

            txt_nome.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_cidade.Clear();

            txt_nome.Focus();

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
