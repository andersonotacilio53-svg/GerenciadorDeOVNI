using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    internal class Gerenciador
    {
        
 
        // objetos globais:
        BibliotecaOVNI.OVNI ovni;


        public Gerenciador(BibliotecaOVNI.OVNI ovni) // Obrigatoriamente deve-se iniciar passando um OVNI
        {
            InitializeComponent();
            // "copiando" o ovni vindo da outra janela para um obj global:
            this.ovni = ovni;

            // Atualizar as informções:
            AtualizarInfomacoes();

            // Popular o combobox com os planetas validos:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);

        }

        public void AtualizarInfomacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligado")}";
            lblPlaneta.Text = $"Planeta atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            // Atualizar os botões ligar e desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;

            // Ativar/desativar p grb de acordo com o status da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informções:
            AtualizarInfomacoes();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi desligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está desligado!.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Atualizar as informções:
            AtualizarInfomacoes();
        }

        private void btnAddTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adicionado",
                     "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A nave ja está lotada de tripulantes",
                     "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInfomacoes();
        }
    }
}
    

