using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UISAEP
{
    public partial class FormCadastrarEquipamento : Form
    {
        public FormCadastrarEquipamento()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                Equipamento equipamento = new Equipamento();
                equipamento.Descricao = descricaoTextBox.Text;
                equipamento.DescricaoDetalhada = descricaoDetalhadaTextBox.Text;
                equipamento.Ativo = checkBoxAtivo.Checked;
                equipamento.Imagem = pictureBoxEquipamento.ImageLocation;
                equipamentoBLL.Inserir(equipamento);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCarregarImagem_Click(object sender, EventArgs e)
        {
            var caminhoArquivo = string.Empty;
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Imagens (*.png)|*.txt|Todos os arquivos (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoArquivo = openFileDialog.FileName;
                    //var fileStream = openFileDialog.OpenFile();
                }
            }
            pictureBoxEquipamento.ImageLocation = caminhoArquivo;
        }
    }
}
