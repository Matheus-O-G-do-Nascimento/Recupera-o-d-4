using System.Collections.Generic;
using System.IO;

namespace Recuperação_d_4.Models
{
    //Superclasse
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        protected string Senha { get; set; }

        public virtual void Login()
        {

        }
        //
         public List<string> ReadAllLinesCSV(string PATH)
        {

            List<string> linhas = new List<string>();
            using (StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }
    }
}