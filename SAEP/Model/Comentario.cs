using System;

namespace Model
{
    public class Comentario
    {
        private int id;
        private string descricao;
        private int id_Equipamento;
        private int id_Perfil;
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
        public int Id_Equipamento
        {
            get { return id_Equipamento; }
            set { id_Equipamento = value; }
        }
        public int Id_Perfil
        {
            get { return id_Perfil; }
            set { id_Perfil = value; }
        }
        public DateTime Data
        {
            get { return date; }
            set { date = value; }
        }
    }
}