namespace Recuperação_d_4.Models
{
    public abstract class NewBaseType
    {
        bool Logar = false;
    }

    public abstract class usuario : NewBaseType
    {
        private string nome;
        private string senha;
        private float email;

        public abstract bool Logar();
    }
}