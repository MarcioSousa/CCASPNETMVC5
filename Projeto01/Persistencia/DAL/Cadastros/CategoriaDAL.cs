using Projeto01.Modelo.Cadastros;
using Projeto01.Persistencia.Contexts;
using System.Data.Entity;
using System.Linq;

namespace Persistencia.DAL.Cadastros
{
    public class CategoriaDAL
    {
        private readonly EFContext context = new EFContext();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return context.Categorias.OrderBy(b =>b.Nome);
        }
        public Categoria ObterCategoriaPorId(long id)
        {
            return context.Categorias.Where(f => f.CategoriaId == id).Include("Produtos.Fabricante").First();
        }
        public void GravarCategoria(Categoria categoria)
        {
            if(categoria.CategoriaId == null)
            {
                context.Categorias.Add(categoria);
            }
            else
            {
                context.Entry(categoria).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Categoria EliminarCategoriaPorId(long id)
        {
            Categoria categoria = ObterCategoriaPorId(id);
            context.Categorias.Remove(categoria);
            context.SaveChanges();
            return categoria;
        }

    }
}
