using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.BookAmostra;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.BookAnexoAmostra
{
    public static class BookAnexoRelation
    {
        public static ModelBuilder BookAnexoRelationConfiguring(this ModelBuilder modelBuilder)
        {
            //TODO trocar a chave primaria
            modelBuilder.Entity<BookAnexo>().HasMany<Book>(u => u.book).WithOne(u => u.bookAnexo).HasForeignKey(u => u.CodProd);
            return modelBuilder;
        }

    }
}