import { Component, OnInit } from '@angular/core';
import { IAvgfrpvgetall } from 'src/app/Domain/Models/IAvgfrpvgetall';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';
import { Grid } from 'src/app/Shared';

@Component({
  selector: 'app-client-grid',
  templateUrl: './client-grid.component.html',
  styleUrls: ['./client-grid.component.scss'],
})
export class ClientGridComponent implements OnInit {
  listTitle: string[] = [
    'codparc',
    'nomeparc',
    'cgc_cpf',
    'CRÉDITO',
    'CRÉDITO DISPONIVEL',
    'atraso',
  ];
  listGridTitle: string[] = [
    'codparc',
    'nomeparc',
    'cgc_cpf',
    'CRÉDITO',
    'CRÉDITO DISPONIVEL',
    'atraso',
  ];
  listGrid: any[] = [];

  grid: Grid;
  constructor(private aDVGFRPVService: ADVGFRPVService) {
    this.grid = new Grid();
  }
  getTitle(t: string) {
    return this.listGridTitle[this.listGridTitle.indexOf(t)];
  }
  async ngOnInit(): Promise<void> {
    this.grid.createGrid({ selectorHtml: '#table_client', paging: false });
    // this.grid.render();
    await this.getAll(1, 10);
    this.grid.render();
  }

  async getAll(page = 1, limit = 10) {
    const response = await this.aDVGFRPVService.getAll(page, limit);
    // this.grid.setData(response.data);
    this.listGrid = response.data;
  }
}
