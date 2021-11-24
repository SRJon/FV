import { IResponse } from '../Domain/Models/IResponse';
import { Paginate } from '../Domain/Models/Paginate';

export class PaginateShare {
  paginateHtml: HTMLElement | null = null;
  paginate: Paginate;

  public constructor() {
    this.paginate = new Paginate(1, 1, [1]);
  }
  setHtml(id: string) {
    // @ts-ignore: Unreachable code error
    this.paginateHtml = $(id);
    this.setPaginate();
  }
  setAttr(res: IResponse<any>) {
    this.paginate.currentPage = res.page;
    this.paginate.pageSize = res.totalPages;
  }
  setPaginate(callback = (e: any) => {}): void {
    // @ts-ignore: Unreachable code error
    this.paginateHtml.pagination({
      total: this.paginate.pageSize * 10,
      current: this.paginate.currentPage,
      click: function (e: any) {
        // ctx.paginate.currentPage = e.current;
        // ctx.clickOnPagination(e.current);
        callback(e.current);
      },
    });
  }
}
