using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velcore.ERP.Domain.Entities
{
    public class Cliente : EntidadeBase
    {
        public Guid EmpresaId { get; private set; }
        public string Nome { get; private set; }
        public string? Documento { get; private set; }
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }

        protected Cliente() { }

        public Cliente(Guid empresaId, string nome, string? documento, string? telefone, string? email)
        {
            Validar(empresaId, nome);

            EmpresaId = empresaId;
            Nome = nome.Trim();
            Documento = documento?.Trim();
            Telefone = telefone?.Trim();
            Email = email?.Trim();
        }

        public void Atualizar(string nome, string? documento, string? telefone, string? email)
        {
            Validar(EmpresaId, nome);

            Nome = nome.Trim();
            Documento = documento?.Trim();
            Telefone = telefone?.Trim();
            Email = email?.Trim();
        }

        private static void Validar(Guid empresaId, string nome)
        {
            if (empresaId == Guid.Empty)
                throw new ArgumentException("EmpresaId é obrigatório.");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do cliente é obrigatório.");
        }
    }
}
