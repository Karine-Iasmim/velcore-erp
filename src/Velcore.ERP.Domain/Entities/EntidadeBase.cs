using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velcore.ERP.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public bool Ativo { get; private set; }

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.UtcNow;
            Ativo = true;
        }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
