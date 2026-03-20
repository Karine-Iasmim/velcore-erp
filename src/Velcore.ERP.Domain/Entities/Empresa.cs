using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velcore.ERP.Domain.Entities
{
    public class Empresa : EntidadeBase
    {
        public string Nome { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public string? Telefone { get; private set; }
        public string? Email { get; private set; }

        protected Empresa() { }

        public Empresa(string nome, string nomeFantasia, string cnpj, string? telefone, string? email)
        {
            Validar(nome, nomeFantasia, cnpj);

            Nome = nome.Trim();
            NomeFantasia = nomeFantasia.Trim();
            Cnpj = cnpj.Trim();
            Telefone = telefone?.Trim();
            Email = email?.Trim();
        }

        public void AtualizarDados(string nome, string nomeFantasia, string cnpj, string? telefone, string? email)
        {
            Validar(nome, nomeFantasia, cnpj);

            Nome = nome.Trim();
            NomeFantasia = nomeFantasia.Trim();
            Cnpj = cnpj.Trim();
            Telefone = telefone?.Trim();
            Email = email?.Trim();
        }

        private static void Validar(string nome, string nomeFantasia, string cnpj)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da empresa é obrigatório.");

            if (string.IsNullOrWhiteSpace(nomeFantasia))
                throw new ArgumentException("Nome fantasia é obrigatório.");

            if (string.IsNullOrWhiteSpace(cnpj))
                throw new ArgumentException("CNPJ é obrigatório.");
        }
    }
}
