import { GeralComponent } from './Components/Geral/Geral.component';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-client_details',
  templateUrl: './client_details.component.html',
  styleUrls: ['./client_details.component.scss'],
})
export class Client_detailsComponent implements OnInit {
  id: string | null = null;
  constructor(private _Activatedroute: ActivatedRoute) {}

  ngOnInit() {
    this._Activatedroute.paramMap.subscribe((params) => {
      this.id = params.get('id');
    });
  }
}
