import { PaginateShare } from './';

export class Grid {
    html: HTMLElement | undefined;
    sharePaginate: PaginateShare;
    private isPaging = false;
    private selector = '';

    public constructor() {
    // super();
        this.sharePaginate = new PaginateShare();
    }

    public createGrid(data: { paging: boolean; selectorHtml: string }): void {
    // @ts-ignore: Unreachable code error
        this.html = $(data.selectorHtml);
        // @ts-ignore: Unreachable code error
        this.selector = data.selectorHtml;
        this.isPaging = data.paging;

    // $(document).ready(() => {
    // if (this.html) {
    //   this.render();
    // }
    // });
    }
    render() {
    // @ts-ignore: Unreachable code error
        const istable = $.fn.dataTable.isDataTable(this.selector);
        if (!istable) {
            // @ts-ignore: Unreachable code error
            this.html.dataTable({
                paging: this.isPaging,
                lengthChange: false,
                info: '',
                language: {
                    zeroRecords: ' ',
                },
            });
        } else {
            // @ts-ignore: Unreachable code error
            this.html.DataTable().destroy();
            // @ts-ignore: Unreachable code error
            this.html.dataTable({
                paging: this.isPaging,
                lengthChange: false,
                info: '',
                language: {
                    zeroRecords: ' ',
                },
            });
        }
    }
}
