using System;

namespace Recuperação_d_4.Models
{
    public class participante : Usuario
    {
        public string ConfirmarChegada()
        {
            return "Confirmado em todos os dias";
        }

        public string ConfirmadoNaData(string nome)
        {
            return $"Confirmado no dia " + nome;
        }
    }
}