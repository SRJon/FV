import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClientTabs } from 'src/app/Models/ClientTabs';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';

@Component({
  selector: 'app-client_details',
  templateUrl: './client_details.component.html',
  styleUrls: ['./client_details.component.scss'],
})
export class Client_detailsComponent implements OnInit {
  id: string | null = null;
  data: ClientTabs;
  intervalTabs: any;
  selected: number = 0;

  constructor(
    private _Activatedroute: ActivatedRoute,
    private service: ADVGFRPVService
  ) {
    this.data = new ClientTabs();
    this.selected = 0;
    this.intervalTabs = setInterval(() => {
      this.checkStateTabs();
    }, 10);
  }

  ngOnInit() {
    this._Activatedroute.paramMap.subscribe((params) => {
      this.id = params.get('id');
      if (this.id) {
        this.service.GetByParc(Number(this.id)).then((response) => {
          this.data.parceiro = response.data;
        });
      }
    });
  }
  checkStateTabs() {
    let b = document.querySelectorAll(
      '#middleWrapper > div.pl-2 > app-client_details > div > div > div > div > div > div.card-header.d-flex.p-0 > ul > li > a'
    );
    let c = Array.from(b);

    let listClassName = c.map((e) => e.className);
    let id = listClassName.map((e) => e.includes('active'));
    this.selected = id.indexOf(true);
  }
  ngOnDestroy() {
    clearInterval(this.intervalTabs);
  }
}
