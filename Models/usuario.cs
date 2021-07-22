namespace Recuperação_d_4.Models
{
    public class Usuario
    {
        public string Nome {get; set;}
        public string Email { get; set; }
        protected string Senha { get; set; }
        
        public virtual void Login(){
            
        }
        
        
    }
}