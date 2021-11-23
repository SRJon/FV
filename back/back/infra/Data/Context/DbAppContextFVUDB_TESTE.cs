
using System;
using back.data.entities.AnexoCont;
using back.data.entities.AnexoDev;
using back.data.entities.AnexoRep;
using back.data.entities.Book;
using back.data.entities.BookAnexo;
using back.data.entities.BProduto;
using back.data.entities.BProdutoImg;
using back.data.entities.Diretorio;

using back.data.entities.Enterprise;
using back.data.entities.Informativo;
using back.data.entities.Parametro;
using back.data.entities.Request;
using back.data.entities.RequestItem;
using back.data.entities.Profile;
using back.data.entities.ProfileScreen;
using back.data.entities.Projetos;
using back.data.entities.Screen;
using back.data.entities.User;

using back.data.entities.UserCustomizations;
using back.data.entities.VersaoProjetos;
using back.data.entities.VersionDetails;

using back.domain.DTO.ScreenDTO;
using back.domain.DTO.User;
using back.ioc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace back.infra.Data.Context
{
    public class DbAppContextFVUDB_TESTE : DbContext
    {

        ILoggerFactory _loggerFactory;

        public DbAppContextFVUDB_TESTE(DbContextOptions<DbAppContextFVUDB_TESTE> options, ILoggerFactory loggerFactory)
        : base(options)
        {
            _loggerFactory = loggerFactory;
            _ = Database.EnsureCreated();

        }

        public DbSet<AnexoCont> AnexoCont { get; set; }
        public DbSet<AnexoDev> AnexoDev { get; set; }
        public DbSet<AnexoRep> AnexoRep { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAnexo> BookAnexo { get; set; }
        public DbSet<BProduto> BProduto { get; set; }
        public DbSet<BProdutoImg> BProdutoImg { get; set; }
        public DbSet<Diretorio> Diretorio { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Informativo> Informativo { get; set; }
        public DbSet<Parametro> Parametro { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<PerfilTela> PerfilTela { get; set; }
        public DbSet<Projetos> Projetos { get; set; }
        public DbSet<Tela> Tela { get; set; }
        public DbSet<UserCustomizations> UserCustomizations { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        //public DbSet<UsuarioEmp> UsuarioEmp { get; set; }
        public DbSet<VersaoProjetos> VersaoProjetos { get; set; }
        public DbSet<VersionDetails> VersionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.EntitiesConfigurationInjection();
            // modelBuilder.Entity<Tela>().HasOne(a => a.tela).WithOne().HasForeignKey<Tela>(a => a.TelaId);


            modelBuilder.UserRelationConfiguring();
            modelBuilder.ProfileScreenConfiguring();
            modelBuilder.ProfileRelationConfiguring();
            modelBuilder.PedidoRelationConfiguring();
            modelBuilder.AnexoRepRelationConfiguring();
            modelBuilder.InformativoRelationConfiguring();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var loggerFactory = LoggerFactory.Create(builder =>
            //{
            //    builder
            //    .AddConsole((options) => { })
            //    .AddFilter((category, level) =>
            //        category == DbLoggerCategory.Database.Command.Name
            //        && level == LogLevel.Information);
            //}
            //    );
            // optionsBuilder.UseLoggerFactory(loggerFactory);
            // optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);



        }

    }

}