using back.domain.Enum;

namespace back.infra.Data.Context
{
    public class DbContexts
    {
        public ConnectionEnvironment environment;
        private DbAppContextGrupoLitoral dbAppContextGrupoLitoral;

        public DbContexts(DbAppContextGrupoLitoral dbAppContextGrupoLitoral)
        {
            this.environment = Settings.ConnectionName;
            this.dbAppContextGrupoLitoral = dbAppContextGrupoLitoral;
        }
        public DbAppContextGrupoLitoral GetGrupoLitoral()
        {
            return dbAppContextGrupoLitoral;
        }

    }
}