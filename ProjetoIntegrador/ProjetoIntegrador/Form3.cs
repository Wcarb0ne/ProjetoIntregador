using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Digite um Usuário !!", "Ifood de PC");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Digite sua senha !!", "Ifood de PC");
            }
            else if (txtSenha.Text == "junin" && txtSenha.Text == "pomba mole")
            {
                this.Hide();
                Form form3 = new Login1();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos", "Ifood de PC");
            }

        }
    }
}
