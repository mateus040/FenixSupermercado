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

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_cpf.Clear();
            txt_data.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_cidade.Clear();

            txt_nome.Focus();
        }
    }
}
