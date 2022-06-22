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
    public partial class Form3 : Form
    {
        public double resultado = 0;
        double troco = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_nome_produto.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
           
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string produto = txt_nome_produto.Text;
            int codigo = int.Parse(txt_codigo.Text);
            int quantidade = int.Parse(txt_quantidade.Text);
            double valor = double.Parse(txt_valor.Text);

            resultado += valor * quantidade;

            lbl_valorTotal.Text = resultado.ToString("C");

            ListViewItem vendas = new ListViewItem(txt_nome_produto.Text);
            vendas.SubItems.Add(txt_codigo.Text);
            vendas.SubItems.Add(txt_quantidade.Text);
            vendas.SubItems.Add(txt_valor.Text);
            list_Vendas.Items.Add(vendas);
        }

        private void btn_receber_Click(object sender, EventArgs e)
        {
            double valor_pago = double.Parse(txt_valorPago.Text);

            troco = valor_pago - resultado;

            lbl_troco.Text = troco.ToString("C");
        }

        private void btn_pagLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
