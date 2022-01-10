using back.data.entities.TGFGrupoProduto;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFGrupoProdutoVendedor
{
    public static class TGFRGVRelation
    {
        public static ModelBuilder TGFRGVRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TGFRGV>().HasOne(c => c.TGFGRU).WithOne().HasForeignKey<TGFGRU>(c => c.CODGRUPOPROD);

            return modelBuilder;
        }
    }
}
