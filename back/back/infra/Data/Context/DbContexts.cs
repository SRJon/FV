using back.domain.Enum;

namespace back.infra.Data.Context
{
    public class DbContexts
    {
        public ConnectionEnvironment environment;
        // private DbAppContextGrupoLitoral dbAppContextGrupoLitoral;
        private DbAppContextFVUDB_TESTE dbAppContextFVUDB_TESTE;

        public DbContexts(DbAppContextFVUDB_TESTE dbFvu )
        {
            this.environment = Settings.ConnectionName;
            // this.dbAppContextGrupoLitoral = dbAppContextGrupoLitoral;
            this.dbAppContextFVUDB_TESTE = dbFvu;
        }
        public DbAppContextFVUDB_TESTE GetVFU()
        {
            return dbAppContextFVUDB_TESTE;
        }
        // public DbAppContextGrupoLitoral GetGrupoLitoral()
        // {
        //     return dbAppContextGrupoLitoral;
        // }

    }
}