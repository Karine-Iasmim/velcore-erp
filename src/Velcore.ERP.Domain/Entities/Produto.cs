using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velcore.ERP.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        public Guid EmpresaId { get; private set; }
        public Guid CategoriaId { get; private set; }

        public string Descricao { get; private set; }
        public string Sku { get; private set; }
        public decimal Preco { get; private set; }

        public bool Ativo { get; private set; }

        protected Produto() { } // EF

        public Produto(Guid empresaId, Guid categoriaId, string descricao, string sku, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(Descricao))
                throw new Exception("Descricao do produto é obrigatório");

            if (preco < 0)
                throw new Exception("Preço inválido");

            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            CategoriaId = categoriaId;
            Descricao = descricao;
            Sku = sku;
            Preco = preco;
            Ativo = true;
            DataCriacao = DateTime.UtcNow;
        }

        public void AtualizarPreco(decimal preco)
        {
            if (preco < 0)
                throw new Exception("Preço inválido");

            Preco = preco;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
