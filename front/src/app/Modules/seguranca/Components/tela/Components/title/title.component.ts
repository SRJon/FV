import { Component, Input, OnInit } from '@angular/core';
import { GlobalTitle } from 'src/app/Shared/GlobalTitle';

@Component({
  selector: 'app-title',
  templateUrl: './title.component.html',
  styleUrls: ['./title.component.scss'],
})
export class TitleComponent implements OnInit {
  @Input() title: string = 'Tela';
  @Input() description: string = '';
  _title: string = '';
  constructor(private globalTitle: GlobalTitle<string>) {
    this.globalTitle.getObservable().subscribe((value) => {
      this._title = value;
    });
  }

  ngOnInit(): void {
    this.globalTitle.setValue(this.title);
  }
}
