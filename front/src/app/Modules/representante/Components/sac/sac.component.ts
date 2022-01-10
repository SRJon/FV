import { Component, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-sac',
  templateUrl: './sac.component.html',
  styleUrls: ['./sac.component.scss'],
})
export class SacComponent implements OnInit {
  title = 'SAC';
  description = '';

  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.setValue(this.title);
  }

  ngOnInit(): void {}
}
