using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UISAEP
{
    public partial class FormComentario : Form
    {
        private int id_Equipamento;

        public FormComentario(int _id_Equipamento)
        {
            InitializeComponent();
            id_Equipamento = _id_Equipamento;

            ListarComentarios();
        }

        private void ListarComentarios()
        {
            ComentarioBLL comentarioBLL = new ComentarioBLL();
            BindingSource comentarioBindingSource = new BindingSource();
            comentarioBindingSource.DataSource = comentarioBLL.Buscar(id_Equipamento);
            comentarioBindingSource.MoveFirst();

            PerfilBLL perfilBLL = new PerfilBLL();
            BindingSource perfilBindingSource = new BindingSource();

            textBox1.Text = "";

            foreach (DataRowView item in comentarioBindingSource)
            {
                perfilBindingSource.DataSource = perfilBLL.Buscar(Convert.ToInt32(item.Row["Id_Perfil"]));

                textBox1.Text = textBox1.Text + ((DataRowView)perfilBindingSource.Current).Row["Descricao"].ToString() + " - " + item.Row["Data"] + "\r\n\r\n"
                     + item.Row["Descricao"] + "\r\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n";
            }
            textBox1.Select(textBox1.Text.Length,0);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastrarComentario frm = new FormCadastrarComentario(id_Equipamento))
            {
                frm.ShowDialog();
            }
            ListarComentarios();
        }
    }
}
