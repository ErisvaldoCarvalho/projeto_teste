using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UISAEP
{
    public partial class FormEquipamento : Form
    {
        public FormEquipamento()
        {
            InitializeComponent();
        }

        private void FormEquipamento_Load(object sender, EventArgs e)
        {
            buttonSair_Click(null, null);
        }
        private void Buscar()
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
            equipamentoBindingSource.DataSource = equipamentoBLL.Buscar("");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
            }
            if (Constantes.Id_Perfil == 0)
                Application.Exit();

            this.Visible = !this.Visible;
            Buscar();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarEquipamento frm = new FormCadastrarEquipamento())
            {
                frm.ShowDialog();
            }
            Buscar();
        }

        private void buttonComentarios_Click(object sender, EventArgs e)
        {
            using (FormComentario frm = new FormComentario(Convert.ToInt32(((DataRowView)equipamentoBindingSource.Current).Row["Id"])))
            {
                frm.ShowDialog();
            }
        }

        private void descricaoDetalhadaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você realmente deseja excluir este equipamento?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                equipamentoBLL.Excluir(Convert.ToInt32(((DataRowView)equipamentoBindingSource.Current).Row["Id"]));
                equipamentoBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
