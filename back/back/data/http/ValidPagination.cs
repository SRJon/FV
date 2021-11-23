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
            skip = (this.page - 1) * limit;
        }
    }
}
