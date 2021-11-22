import { PaginateShare } from './';

export class Grid {
  html: HTMLElement | undefined;
  sharePaginate: PaginateShare;

  public constructor() {
    // super();
    this.sharePaginate = new PaginateShare();
  }

  public createGrid(
    data: { paging: boolean; selectorHtml: string },
    ctx: any
  ): void {
    // @ts-ignore: Unreachable code error
    this.html = $(data.selectorHtml);
    console.log(this.html);

    if (this.html) {
      // @ts-ignore: Unreachable code error
      this.html.dataTable({
        paging: data.paging,
        lengthChange: false,
        info: '',
        language: {
          zeroRecords: ' ',
        },
      });
    }

    ctx.setPaginate(ctx);
  }
}
