using System.Collections.Generic;

namespace Gerente.Dominio.Entidades
{
    public class Usuario : Base
    {

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }


        //EF
        protected Usuario()
        {

        }
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            _erros = new List<string>();
        }

        public void MudarNome(string nome)
        {
            Nome = nome;
            Validador();
        }

        public void MudarEmail(string email)
        {
            Email = email;
            Validador();
        }
        public void MudarSenha(string senha)
        {
            Senha = senha;
            Validador();
        }


        public override bool Validador()
        {
            throw new System.NotImplementedException();
        }
    }
}