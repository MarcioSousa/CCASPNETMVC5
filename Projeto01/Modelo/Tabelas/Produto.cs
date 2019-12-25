using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Projeto01.Modelo.Cadastros;

namespace Projeto01.Modelo.Tabelas
{
    public class Produto
    {
        [DisplayName("Id")]
        public long? ProdutoId { get; set; }

        [StringLength(100, ErrorMessage ="O nome do produto precisa ter no mínimo 10 caracteres",MinimumLength =10)]
        [Required(ErrorMessage ="Infome o nome do produto")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Dt.Cadastro")]
        [Required(ErrorMessage ="Informe a data de cadastro do produto")]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }

        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}