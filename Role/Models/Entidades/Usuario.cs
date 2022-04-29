using System;

namespace Role.Models.Entidades
{
    public class Usuario : EntidadeBase
    {
        protected Usuario()
        {
        }

        public virtual string Nome { get; private set; }
        public virtual string Email { get; private set; }
        public virtual string Telefone { get; private set; }
        public virtual string Cidade { get; private set; }
        public virtual DateTime DataNascimento { get; private set; }
    }
}
