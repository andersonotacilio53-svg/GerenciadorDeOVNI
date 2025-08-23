using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            // Adicionar os planetas no comboBox:
            cmbPlanta.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar se o numero0 de tripulantes esta vazio:
            if (txbTipulantes.Text == "")
            {
                MessageBox.Show("Informe o máximo de tripulantes!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAbduzidos.Text == "")
            {
                MessageBox.Show("Informe capacidade  do compartimento de Abduzidos!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbPlanta.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o planeta de origem!", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                // Variaveis para receber os valores dos txbs:
                int maxTripulantes = int.Parse(txbTipulantes.Text);
                int maxAbduzidos = int.Parse(txbAbduzidos.Text);
                string planetaOrigem = cmbPlanta.Text;

                // Instanciar o OVNI:  
                BibliotecaOVNI.OVNI OVNI = new BibliotecaOVNI.OVNI(maxTripulantes,maxAbduzidos,planetaOrigem) ;
            }
        }
    }
}
