using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _211069_211090
{
    public partial class Form1 : Form
    {
        bool mover = false;
        Point posicao_incial;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            btnMinimizar.Visible = true;
            btnMaximizar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void AbrirFormNoPapel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPapel<Form2>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPapel <Form3>();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormNoPapel<Form4>();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPapel<Form5>();
        }

        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_incial = new Point(e.X, e.Y);
        }

        private void panelCabecalho_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_incial.X, novo.Y - posicao_incial.Y);
            }
        }
    }
}
