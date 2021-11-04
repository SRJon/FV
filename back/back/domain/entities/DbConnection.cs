
namespace back.domain.entities
{
    public abstract class DbConnection
    {
        // Database teste 200.4
        private string SANKHYA_FVU_TESTE = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=FVUDB_TESTE;Data Source=10.200.200.4";
        private string SANKHYA_TESTE = "Password=litsnk;Persist Security Info=True;User ID=sankhya;Initial Catalog=SANKHYA_TESTE;Data Source=10.200.200.4";
        private string GRUPOLITORAL = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=grupolitoral;Data Source=10.200.200.4";


        // database teste 0.253




        public string getConnectionString(int database)
        {
            switch (database)
            {
                case 0:
                    return SANKHYA_FVU_TESTE;
                case 1:
                    return SANKHYA_TESTE;
                case 2:
                    return GRUPOLITORAL;
                default:
                    return SANKHYA_FVU_TESTE;
            }
        }
    }
}