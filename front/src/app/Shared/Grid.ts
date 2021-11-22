import { PaginateShare } from './';

export class Grid {
  html: HTMLElement | undefined;
  sharePaginate: PaginateShare;

  public constructor() {
    // super();
    this.sharePaginate = new PaginateShare();
  }

  public createGrid(data: { paging: boolean; selectorHtml: string }): void {
    // @ts-ignore: Unreachable code error
    this.html = $(data.selectorHtml);

    if (this.html) {
      console.log(this.html);
      $(document).ready(() => {
        // @ts-ignore: Unreachable code error
        this.html.dataTable({
          paging: data.paging,
          lengthChange: false,
          info: '',
          language: {
            zeroRecords: ' ',
          },
        });
      });
    }
  }
}
