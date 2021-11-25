
namespace back.domain.entities
{
    public abstract class DbConnection
    {
        // Database teste 200.4
        private string SANKHYA_FVU_TESTE = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=FVUDB_TESTE;Data Source=10.200.200.4";
        private string SANKHYA_TESTE = "Password=litsnk;Persist Security Info=True;User ID=sankhya;Initial Catalog=SANKHYA_TESTE;Data Source=10.200.200.4";
        private string GRUPOLITORAL_TESTE = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=grupolitoral;Data Source=10.200.200.4";


        // database teste 0.253
        private string SANKHYA_FVU_PROD = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=FVUDB_TESTE;Data Source=10.200.200.4";
        private string SANKHYA_PROD = "Password=litsnk;Persist Security Info=True;User ID=sankhya;Initial Catalog=SANKHYA_TESTE;Data Source=10.200.200.4";
        private string GRUPOLITORAL_PROD = "Password=lL!yLl$h87Oe;Persist Security Info=True;User ID=user_grp_litoral;Initial Catalog=grupolitoral;Data Source=10.200.200.4";


        private string SANKHYA_FVU;
        private string SANKHYA;
        private string GRUPOLITORAL;

        public DbConnection(bool production)
        {
            if (production)
            {
                SANKHYA_FVU = SANKHYA_FVU_PROD;
                SANKHYA = SANKHYA_PROD;
                GRUPOLITORAL = GRUPOLITORAL_PROD;
            }
            else{
                SANKHYA_FVU = SANKHYA_FVU_TESTE;
                SANKHYA = SANKHYA_TESTE;
                GRUPOLITORAL = GRUPOLITORAL_TESTE;
            }
        }



        public string getConnectionString(int database)
        {
            switch (database)
            {
                case 0:
                    return SANKHYA_FVU;
                case 1:
                    return SANKHYA;
                case 2:
                    return GRUPOLITORAL;
                default:
                    return SANKHYA_FVU;
            }
        }
    }
}