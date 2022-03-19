using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Kayami72CEduc
{
    public partial class frmFrase : Form
    {
        string Frase = "";
        string resp = "A Onça Pintada Vive Na Mata ";
        public frmFrase()
        {
            InitializeComponent();
        }

        private void btnOnça_Click(object sender, EventArgs e)
        {
            Frase += btnOnça.Text + " ";
            lblResposta.Text = Frase;
            btnOnça.BackColor = Color.White;

        }

        private void btnMata_Click(object sender, EventArgs e)
        {
            Frase += btnMata.Text + " ";
            lblResposta.Text = Frase;
            btnMata.BackColor = Color.White;
        }

        private void btnPintada_Click(object sender, EventArgs e)
        {
            Frase += btnPintada.Text + " ";
            lblResposta.Text = Frase;
            btnPintada.BackColor = Color.White;
        }

        private void btnVive_Click(object sender, EventArgs e)
        {
            Frase += btnVive.Text + " ";
            lblResposta.Text = Frase;
            btnVive.BackColor = Color.White;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Frase += btnA.Text + " ";
            lblResposta.Text = Frase;
            btnA.BackColor = Color.White;
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            Frase += btnNa.Text + " ";
            lblResposta.Text = Frase;
            btnNa.BackColor = Color.White;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";
            Frase = "";
            Limparbotao();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string guarda = "";
            guarda = lblResposta.Text;
            if (guarda == resp)
            {
                DialogResult caixa;
                caixa = MessageBox.Show("Parabéns Você acertou",
                                        "Exercicio palavra",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                lblResposta.Text = "";
                Frase = "";
                Limparbotao();
                DialogResult resposta;
                resposta = MessageBox.Show("A atividade acabou, agora você pode fechar a atividade",
                                "Exercico Frase",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Question);
            }
            if (guarda != resp)
            {
                DialogResult caixa;
                caixa = MessageBox.Show("Algo não está certo",
                                        "Exercicio palavra",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Hand);
                lblResposta.Text = "";
                Frase = "";
                Limparbotao();
            }
        }
        public void Limparbotao()
        {
            btnNa.BackColor = Color.Cyan;
            btnPintada.BackColor = Color.Cyan;
            btnVive.BackColor = Color.Cyan;
            btnMata.BackColor = Color.Cyan;
            btnA.BackColor = Color.Cyan;
            btnOnça.BackColor = Color.Cyan;
        }
    }
}
