using Projeto01.Modelo.Tabelas;
using System.Collections.Generic;

namespace Projeto01.Modelo.Cadastros
{
    public class Fabricante
    {
        public long? FabricanteId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}