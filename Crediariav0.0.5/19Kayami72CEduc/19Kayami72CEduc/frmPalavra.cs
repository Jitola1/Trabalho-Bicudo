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
    public partial class frmPalavra : Form
    {
        string palavra = "";
        string maco = "MaCaCo";
        public frmPalavra()
        {
            InitializeComponent();
        }

        private void btnMa_Click(object sender, EventArgs e)
        {
            palavra += btnMa.Text;
            lblResposta.Text = palavra;
            btnMa.BackColor = Color.White;
        }

        private void btnCu_Click(object sender, EventArgs e)
        {
            palavra += btnCu.Text;
            lblResposta.Text = palavra;
            btnCu.BackColor = Color.White;
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            palavra += btnMe.Text;
            lblResposta.Text = palavra;
            btnMe.BackColor = Color.White;
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            palavra += btnCa.Text;
            lblResposta.Text= palavra;
            btnCa.BackColor = Color.White;
        }

        private void btnMu_Click(object sender, EventArgs e)
        {
            palavra += btnMu.Text;
            lblResposta.Text = palavra;
            btnMu.BackColor = Color.White;
        }

        private void btnPu_Click(object sender, EventArgs e)
        {
            palavra += btnPu.Text;
            lblResposta.Text = palavra;
            btnPu.BackColor = Color.White;
        }

        private void btnPa_Click(object sender, EventArgs e)
        {
            palavra += btnPa.Text;
            lblResposta.Text = palavra;
            btnPa.BackColor = Color.White;
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            palavra += btnCo.Text;
            lblResposta.Text = palavra;
            btnCo.BackColor = Color.White;
        }

        private void btnPe_Click(object sender, EventArgs e)
        {
            palavra += btnPe.Text;
            lblResposta.Text = palavra;
            btnPe.BackColor = Color.White;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string guarda = "";
            guarda = lblResposta.Text;
            if (guarda == maco)
            {
                DialogResult caixa;
                caixa = MessageBox.Show("Parabéns Você acertou, Clique no Botão 'Proximo' para continuar",
                                        "Exercicio palavra",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                lblResposta.Text = "";
                palavra = "";
                limparBotao();
                btnProximo.Visible = true;

            }
            if(guarda != maco)
            {
                DialogResult caixa;
                caixa = MessageBox.Show("Algo não está certo",
                                        "Exercicio palavra",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Hand);
                lblResposta.Text = "";
                palavra = "";
                limparBotao();
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";
            palavra = "";
            limparBotao();
        }

        public void limparBotao()
        {
            btnCa.BackColor = Color.Cyan;
            btnPa.BackColor = Color.Cyan;
            btnPu.BackColor = Color.Cyan;
            btnPe.BackColor = Color.Cyan;
            btnMu.BackColor = Color.Cyan;
            btnMe.BackColor = Color.Cyan;
            btnMa.BackColor = Color.Cyan;
            btnCu.BackColor = Color.Cyan;
            btnCo.BackColor = Color.Cyan;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            frmFrase abrirfrase = new frmFrase();
            abrirfrase.ShowDialog();
        }

        private void frmPalavra_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente sair ?",
                            "Exercico Palavra",
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question); 
            if (resposta == DialogResult.No)
                e.Cancel = true;
        }
    }
}
