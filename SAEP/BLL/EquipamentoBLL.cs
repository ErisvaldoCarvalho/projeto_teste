using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class EquipamentoBLL
    {
        public void Inserir(Equipamento _equipamento)
        {
            if (string.IsNullOrEmpty(_equipamento.Imagem))
                _equipamento.Imagem = "";

            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
            equipamentoDAL.Inserir(_equipamento);
        }
        public DataTable Buscar(string _descricao)
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
            return equipamentoDAL.Buscar(_descricao);
        }
        public void Excluir(int _id)
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
            equipamentoDAL.Excluir(_id);
        }
    }
}