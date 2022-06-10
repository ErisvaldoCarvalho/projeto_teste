using BLL;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace UISAEP
{
    public partial class FormLogin : Form
    {
        private string senha;

        public FormLogin()
        {
            InitializeComponent();
            Constantes.Id_Perfil = 0;
            Constantes.Id_Usuario = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            senha = senha + "1";
            Display();
        }

        private void Display()
        {
            panel1.Focus();
            labelSenha.Text = "";
            for (int i = 0; i < senha.Length; i++)
            {
                labelSenha.Text = labelSenha.Text + "*";
            }
            buttonEntrar.Enabled = senha.Length >= 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            senha = senha + "2";
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            senha = senha + "3";
            Display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            senha = senha + "4";
            Display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            senha = senha + "5";
            Display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            senha = senha + "6";
            Display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            senha = senha + "7";
            Display();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            senha = senha + "8";
            Display();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            senha = senha + "9";
            Display();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            senha = senha + "0";
            Display();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            senha = "";
            //labelSenha.Text = senha;
            Display();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario usuario = new Usuario();
                BindingSource usuarioBindingSource = new BindingSource();
                usuarioBindingSource.DataSource = usuarioBLL.Buscar(senha);
                if (usuarioBindingSource.Count > 0)
                {
                    Constantes.Id_Usuario = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
                    Constantes.Id_Perfil = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id_Perfil"]);
                    Close();
                }
                else
                    MessageBox.Show("Senha incorreta!");

                buttonC_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonC_Click(null, null);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            senha = "";
            Display();
        }
    }
}