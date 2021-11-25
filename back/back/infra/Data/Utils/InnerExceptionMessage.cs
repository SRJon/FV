namespace back.infra.Data.Utils
{
    public static class InnerExceptionMessage
    {
        public static string InnerExceptionError(System.Exception e)
        {
            return " " + e.InnerException.Message.Split("tabela")[0];
        }
    }
}