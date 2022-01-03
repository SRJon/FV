import { IResponse } from '../Domain/Models/IResponse';
import { Paginate } from '../Domain/Models/Paginate';

export class PaginateShare {
  paginateHtml: HTMLElement | null = null;
  paginate: Paginate;
  showPageNumbers: boolean = false;
  callback: any;

  public constructor() {
    this.paginate = new Paginate(1, 1, [1]);
  }
  setEnabePageNumbers(value: boolean) {
    this.showPageNumbers = value;

    this.setPaginate();
  }
  reset() {
    // @ts-ignore: Unreachable code error
    this.paginateHtml.empty();
  }
  setHtml(id: string) {
    // @ts-ignore: Unreachable code error
    this.paginateHtml = $(id);
    this.setPaginate();
  }
  setAttr(res: IResponse<any>) {
    this.paginate.currentPage = res.page;
    this.paginate.pageSize = res.totalPages;
    this.paginate.setPage();
  }
  setPaginate(callback?: any): void {
    console.log(this);

    if (!callback) {
      console.log(this.callback, 'callback');
      this.callback = callback;
    }
    this.reset();
    this.paginate.setPage();
    let instance = this;
    // @ts-ignore: Unreachable code error
    this.paginateHtml.pagination({
      total: this.paginate.pageSize * this.paginate.limit,
      current: this.paginate.currentPage,
      pageSize: this.paginate.limit,
      showPageNumbers: this.showPageNumbers,
      showNavigator: true,
      click: function (e: any) {
        // ctx.paginate.currentPage = e.current;
        // ctx.clickOnPagination(e.current);
        instance.callback(e);
        console.log(instance);
        // this.callback(e.current);
      },
    });
  }
}
