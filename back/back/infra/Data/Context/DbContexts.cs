using back.domain.Enum;

namespace back.infra.Data.Context
{
    public class DbContexts
    {
        public ConnectionEnvironment environment;
        // private DbAppContextGrupoLitoral dbAppContextGrupoLitoral;
        private DbAppContextFVUDB_TESTE dbAppContextFVUDB;
        private DbAppContextSankhya dbAppContextSankhya;


        public DbContexts(DbAppContextFVUDB_TESTE dbFvu, DbAppContextSankhya dbSan)
        {
            this.environment = Settings.ConnectionName;

            // this.dbAppContextGrupoLitoral = dbAppContextGrupoLitoral;
            this.dbAppContextFVUDB = dbFvu;
            this.dbAppContextSankhya = dbSan;
        }
        public DbAppContextSankhya GetSankhya()
        {
            return dbAppContextSankhya;
        }
        public DbAppContextFVUDB_TESTE GetVFU()
        {
            return dbAppContextFVUDB;
        }
        // public DbAppContextGrupoLitoral GetGrupoLitoral()
        // {
        //     return dbAppContextGrupoLitoral;
        // }

    }
}