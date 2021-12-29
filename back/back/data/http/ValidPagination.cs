namespace back.data.http
{
    public abstract class ValidPagination
    {

        public int page { get; set; }
        public int limit { get; set; }
        public int skip { get; set; }
        public ValidPagination()
        {

        }

        protected void ValidPaginate(int page, int limit)
        {
            this.page = page;
            this.limit = limit;


            if (page == 0)
                this.page = 1;

            if (limit == 0)
                this.limit = int.MaxValue;
            skip = (this.page - 1) * this.limit;
        }
        protected int getTotalPages(int totalPages)
        {
            var result = totalPages / this.limit;

            /*
             * Verifica através da operação de módulo se existem registros na página posterior
             */
            if(totalPages % this.limit > 0 && result >= 1)
            {
                result++;
            }


            return result == 0 ? 0 : result;
        }
    }
}
