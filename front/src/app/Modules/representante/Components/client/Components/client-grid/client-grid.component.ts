import { Component, OnInit } from '@angular/core';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';
import { Grid } from 'src/app/Shared';

@Component({
    selector: 'app-client-grid',
    templateUrl: './client-grid.component.html',
    styleUrls: ['./client-grid.component.scss'],
})
export class ClientGridComponent implements OnInit {
    isShowing = false;
    lastI = 0;
    listTitle: string[] = [
        'codparc',
        'nomeparc',
        'cgc_cpf',
        'CRÉDITO',
        'CRÉDITO DISPONIVEL',
        'atraso',
    ];
    listGridTitle: string[] = [
        'Codigo',
        'Nome Par',
        'cgc/cpf',
        'CRÉDITO',
        'CRÉDITO DISPONIVEL',
        'atraso',
    ];
    listGrid: any[] = [];

    grid: Grid;
    constructor(private aDVGFRPVService: ADVGFRPVService) {
        this.grid = new Grid();
        this.lastI = this.listTitle.length + 1;
    }
    getTitle(t: string) {
        const i = this.listTitle.indexOf(t);
        return this.listGridTitle[i];
    }
    async ngOnInit(): Promise<void> {
        this.showGrid(false);
        this.grid.createGrid({ selectorHtml: '#table_client', paging: false });
        // this.grid.render();
        await this.getAll(1, 10);
        this.grid.render();
        this.showGrid(true);
        this.gridEvents();
    }

    async getAll(page = 1, limit = 10) {
        try {
            const response = await this.aDVGFRPVService.getAll(page, limit);
            // this.grid.setData(response.data);
            this.listGrid = response.data;
        } catch (error) {
            console.log(error);
        }
    }

    showGrid(show: boolean) {
        this.isShowing = show;
        // let grid = document.getElementById('table_client');

    // if (show) {
    //   grid!.style!.opacity = '1';
    // } else {
    //   grid!.style!.opacity = '0';
    // }
    }

    gridEvents() {
    // $('th').hover((e) => {
    //   $(e.target).toggleClass('hov-column-head-ver5');

        //   let index = $(e.target).index();
        //   index++;
        //   let tds = $(`[data-column=column${index}]`);
        //   delete tds[0];

        //   tds.toggleClass('hov-column-ver5');
        // });

        const inter = setInterval(() => {
            if ($('td').length > 0) {
                $('td').hover((e) => {
                    let index = $(e.target).index();
                    index++;

                    const tds = $(`td[data-column=column${index}]`);
                    tds.toggleClass('hov-column-ver5');

                    // let ths = $(`th[data-column=column${index}]`);
                    // ths.toggleClass(' hov-column-head-ver5');
                    const childrens = e.currentTarget.parentElement?.children;

                    if (childrens) {
                        const ch = $(childrens);
                        ch.toggleClass('hov-column-ver5');
                    }
                });
                clearInterval(inter);
            }
        }, 100);
    }
    toNumber(value: any, t: any, isTitle = false) {
        return Number(value) + Number(t);
    }
}
