namespace Model
{
    public class Usuario
    {
        private int id;
        private string senha;
        private int id_Perfil;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public int Id_Perfil
        {
            get { return id_Perfil; }
            set { id_Perfil = value; }
        }
    }
}