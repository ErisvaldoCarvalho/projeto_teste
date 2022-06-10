using System;

namespace Model
{
public    class Equipamento
    {
        private int id;
        private string descricao;
        private string imagem;
        private string descricaoDetalhada;
        private bool ativo;
        private DateTime data;

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
        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }
        public string DescricaoDetalhada
        {
            get { return descricaoDetalhada; }
            set { descricaoDetalhada = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
