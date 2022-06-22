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

        }
    }
}
