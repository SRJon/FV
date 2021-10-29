namespace back.data.entities.User
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
            if (page == 0)
                page = 1;

            if (limit == 0)
                limit = int.MaxValue;
            skip = (page - 1) * limit;
        }
    }
}
