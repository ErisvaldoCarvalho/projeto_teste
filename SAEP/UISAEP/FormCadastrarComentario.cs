using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UISAEP
{
    public partial class FormCadastrarComentario : Form
    {
        private int id_Equipamento;

        public FormCadastrarComentario(int _id_Equipamento)
        {
            InitializeComponent();
            id_Equipamento = _id_Equipamento;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ComentarioBLL comentarioBLL = new ComentarioBLL();
                Comentario comentario = new Comentario();
                comentario.Descricao = textBox1.Text;
                comentario.Id_Equipamento = id_Equipamento;
                comentario.Id_Perfil = Constantes.Id_Perfil;
                comentarioBLL.Inserir(comentario);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
