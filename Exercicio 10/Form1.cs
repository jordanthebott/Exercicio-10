using System.Net.Mail;

namespace Exercicio_10
{
    public partial class Form1 : Form
    {
        string cortsenha = "Hello";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Entrar", "", MessageBoxButtons.OK);
            while (true)
            {
                string senha = Microsoft.VisualBasic.Interaction.InputBox("Insira a senha");
                if (senha == cortsenha)
                {
                    MessageBox.Show("Bem vindo ao C#");
                    break;
                }
                else
                {
                    MessageBox.Show("Senha Incorreta. Tente novamente.");
                }
            }
        }
    }
}