using back.data.entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.UserEmp
{
    public static class UsuarioEmpRelation
    {
        public static ModelBuilder UserEmpRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEmp>().HasOne(a => a.Empresa);

            return modelBuilder;
        }
    }
}
