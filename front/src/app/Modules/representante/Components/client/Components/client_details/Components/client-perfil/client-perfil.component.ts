import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Pedido } from 'src/app/Domain/Models/IPedido';
import { ADVGFRPVService } from 'src/app/Modules/representante/Services/AD_VGFRPV/ad-vgfrpv.service';

@Component({
  selector: 'app-client-perfil',
  templateUrl: './client-perfil.component.html',
  styleUrls: ['./client-perfil.component.scss'],
})
export class ClientPerfilComponent implements OnInit {
  data: { value: string; key: string }[] = [];
  id: string = '';
  listGrid: Pedido[] = [];
  size: number = 0;
  constructor(
    private services: ADVGFRPVService,
    private _Activatedroute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this._Activatedroute.paramMap.subscribe((params) => {
      this.id = params.get('id') as string;
      if (this.id) {
        this.services.GetAllByCodParc(Number(this.id)).then((result) => {
          this.listGrid = result.data;
        });
      }
    });
  }

  onChange(m: { value: string; key: string }[]) {
    this.data = m;
  }
  onResized(m: number) {
    this.size = m;
  }
}
