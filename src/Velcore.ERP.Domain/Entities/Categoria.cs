using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velcore.ERP.Domain.Entities
{
    public class Categoria : EntidadeBase
    {
        public Guid EmpresaId { get; private set; }
        public string Nome { get; private set; }
        public string? Descricao { get; private set; }

        protected Categoria() { }

        public Categoria(Guid empresaId, string nome, string? descricao)
        {
            Validar(empresaId, nome);

            EmpresaId = empresaId;
            Nome = nome.Trim();
            Descricao = descricao?.Trim();
        }

        public void Atualizar(string nome, string? descricao)
        {
            Validar(EmpresaId, nome);

            Nome = nome.Trim();
            Descricao = descricao?.Trim();
        }

        private static void Validar(Guid empresaId, string nome)
        {
            if (empresaId == Guid.Empty)
                throw new ArgumentException("EmpresaId é obrigatório.");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da categoria é obrigatório.");
        }
    }
}
