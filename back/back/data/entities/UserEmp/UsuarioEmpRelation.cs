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
            
            //modelBuilder.Entity<UsuarioEmp>().HasMany(a => a.Empresa).WithOne().HasPrincipalKey(a => a.EmpresaId);

            //modelBuilder.Entity<UsuarioEmp>().HasMany(a => a.Usuario).WithOne().HasPrincipalKey(a => a.UsuarioId);
            // var mm = modelBuilder.Entity<UsuarioEmp>();
            // mm.HasMany(a => a.Empresa);
            return modelBuilder;
        }
    }
}
