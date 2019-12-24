using Persistencia.DAL.Tabelas;
using Projeto01.Modelo.Tabelas;
using System.Linq;

namespace Servico.Tabelas
{
    public class ProdutoServico
    {
        private readonly ProdutoDAL produtoDAL = new ProdutoDAL();

        public IQueryable ObterProdutosClassificadosPorNome()
        {
            return produtoDAL.ObterCategoriasClassificadasPorNome();
        }

        public Produto ObterProdutoPorId(long id)
        {
            return produtoDAL.ObterProdutoPorId(id);
        }
        public void GravarProduto(Produto produto)
        {
            produtoDAL.GravarProduto(produto);
        }
        public Produto EliminarProdutoPorId(long id)
        {
            return produtoDAL.EliminarProdutoPorId(id);
        }

    }
}
