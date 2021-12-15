import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-client-perfil',
  templateUrl: './client-perfil.component.html',
  styleUrls: ['./client-perfil.component.scss'],
})
export class ClientPerfilComponent implements OnInit {
  data: { value: string; key: string }[] = [];
  constructor() {}

  ngOnInit(): void {}

  onChange(m: { value: string; key: string }[]) {
    this.data = m;
  }
}
