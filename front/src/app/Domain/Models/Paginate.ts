export class Paginate {
  pageSize: number = 10;
  listPage: number[] = [];
  totalItems: number = 0;

  constructor(
    public total: number,
    public currentPage: number = 1,
    public pageSizeOptions: number[] = [10, 20, 30, 40, 50]
  ) {
    this.currentPage = currentPage;
    this.pageSize = total;
    this.listPage = [];
    this.setPage();
  }
  setPage() {
    this.listPage = Array(this.pageSize)
      .fill(0)
      .map((e, i) => i + 1);
  }
}
