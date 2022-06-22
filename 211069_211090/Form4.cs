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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            int cpf = int.Parse(txt_cpf.Text);
            string cargo = txt_cargo.Text;
            string email = txt_email.Text;
            int telefone = int.Parse(txt_telefone.Text);
            string cidade = txt_cidade.Text;

            ListViewItem funcionarios = new ListViewItem(txt_nome.Text);
            funcionarios.SubItems.Add(txt_cpf.Text);
            funcionarios.SubItems.Add(txt_cargo.Text);
            funcionarios.SubItems.Add(txt_email.Text);
            funcionarios.SubItems.Add(txt_telefone.Text);
            funcionarios.SubItems.Add(txt_cidade.Text);
            listView_Funcionarios.Items.Add(funcionarios);

            txt_nome.Clear();
            txt_telefone.Clear();
            txt_cargo.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_cidade.Clear();

            txt_nome.Focus();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
