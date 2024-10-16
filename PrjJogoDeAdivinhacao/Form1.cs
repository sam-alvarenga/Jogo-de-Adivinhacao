using System;

namespace PrjJogoDeAdivinhacao
{
    public partial class Form1 : Form
    {
        private int numeroSorteado;
        private int tentativas;

        public Form1()
        {
            InitializeComponent();

            ReiniciarJogo();
        }

        private void btnAdivinhar_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtNumero.Text, out int palpite))
            {
                if (palpite < 1 || palpite > 100)
                {
                    MessageBox.Show("Por favor, insira um número entre 1 e 100.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tentativas++;
                if (palpite < numeroSorteado)
                {
                    MessageBox.Show("Muito baixo! Tente novamente.", "Resultado", MessageBoxButtons.OK);
                }
                else if (palpite > numeroSorteado)
                {
                    MessageBox.Show("Muito alto! Tente novamente.", "Resultado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Parabéns Você Acertou! Adivinhou o número em {tentativas} tentativas!", "Congratulations", MessageBoxButtons.OK);

                    ReiniciarJogo();
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK);
            }

        }
        private void ReiniciarJogo()
        {
            Random random = new Random();
            numeroSorteado = random.Next(1, 101);
            tentativas = 0;
            txtNumero.Clear();
            txtNumero.Focus();
        }
    }
}