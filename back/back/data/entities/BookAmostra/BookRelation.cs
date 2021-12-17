using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.BookAnexoAmostra;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.BookAmostra
{
    public static class BookRelation
    {
        public static ModelBuilder BookRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasOne<BookAnexo>(u => u.bookAnexo).WithMany(u => u.book);
            return modelBuilder;
        }
    }
}