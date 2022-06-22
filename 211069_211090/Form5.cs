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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string empresa = txt_empresa.Text;
            int cnpj = int.Parse(txt_cnpj.Text);
            string endereco = txt_endereco.Text;
            string bairro = txt_bairro.Text;
            string cidade = txt_cidade.Text;
            int cep = int.Parse(txt_cep.Text);
            string funcao = txt_funcao.Text;
            string email = txt_email.Text;

            ListViewItem fornecedores = new ListViewItem(txt_empresa.Text);
            fornecedores.SubItems.Add(txt_cnpj.Text);
            fornecedores.SubItems.Add(txt_endereco.Text);
            fornecedores.SubItems.Add(txt_bairro.Text);
            fornecedores.SubItems.Add(txt_cidade.Text);
            fornecedores.SubItems.Add(txt_cep.Text);
            fornecedores.SubItems.Add(txt_funcao.Text);
            fornecedores.SubItems.Add(txt_email.Text);
            listView_Funcionarios.Items.Add(fornecedores);

            txt_empresa.Clear();
            txt_cnpj.Clear();
            txt_endereco.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_cep.Clear();
            txt_funcao.Clear();
            txt_email.Clear();

            txt_empresa.Focus();

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
