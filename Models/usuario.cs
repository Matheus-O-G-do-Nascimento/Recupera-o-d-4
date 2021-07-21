namespace Recuperação_d_4.Models
{
    public abstract class usuario
    {
        private string nome;
        private string senha;
        private float email;

        public abstract bool Logar();
    }
}