using System;

namespace Model
{
    public class Comentario
    {
        private int id;
        private string descricao;
        //private int equipamentoId;
        //private int perfilId;
        private Perfil perfil;
        private Equipamento equipamento;
        private DateTime date;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        //public int EquipamentoId
        //{
        //    get { return equipamentoId; }
        //    set { equipamentoId = value; }
        //}
        //public int PerfilId
        //{
        //    get { return perfilId; }
        //    set { perfilId = value; }
        //}
        public Equipamento Equipamento
        {
            get { return equipamento; }
            set { equipamento = value; }
        }

        public Perfil Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public DateTime Data
        {
            get { return date; }
            set { date = value; }
        }
    }
}