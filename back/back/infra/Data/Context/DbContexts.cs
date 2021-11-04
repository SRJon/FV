using back.domain.Enum;

namespace back.infra.Data.Context
{
    public class DbContexts
    {
        public ConnectionEnvironment environment;
        private DbAppContextGrupoLitoral dbAppContextGrupoLitoral;
        // private DbAppContextFVUDB_TESTE dbAppContextFVUDB_TESTE;

        public DbContexts(DbAppContextGrupoLitoral dbAppContextGrupoLitoral)
        {
            this.environment = Settings.ConnectionName;
            this.dbAppContextGrupoLitoral = dbAppContextGrupoLitoral;
            // this.dbAppContextFVUDB_TESTE = dbFvu;
        }
        public DbAppContextGrupoLitoral GetGrupoLitoral()
        {
            return dbAppContextGrupoLitoral;
        }

    }
}