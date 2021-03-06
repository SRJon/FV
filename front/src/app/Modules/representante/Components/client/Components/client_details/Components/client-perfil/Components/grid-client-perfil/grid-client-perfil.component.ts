import {
  Component,
  OnInit,
  Input,
  HostListener,
  Output,
  EventEmitter,
} from '@angular/core';
import { Pedido } from 'src/app/Domain/Models/IPedido';
import { PaginateShare } from 'src/app/Shared';

@Component({
  selector: 'app-grid-client-perfil',
  templateUrl: './grid-client-perfil.component.html',
  styleUrls: ['./grid-client-perfil.component.scss'],
})
export class GridClientPerfilComponent implements OnInit {
  @Input() listGrid: Pedido[] = [];
  contentHeight: number = 0;
  @Output() onResized: EventEmitter<number>;
  @Output() onPageChange: EventEmitter<number>;
  @Input() paginate!: PaginateShare;

  constructor() {
    this.onPageChange = new EventEmitter<number>();
    this.onResized = new EventEmitter<number>();
  }

  ngOnInit(): void {
    this.getSize();
  }

  @HostListener('window:resize', ['$event'])
  resized() {
    this.getSize();
  }
  getSize() {
    let contentHeight = document.querySelector(
      '#tab_2 > app-client-perfil > div > div'
    )?.clientHeight;

    this.contentHeight = contentHeight || 0;
    this.contentHeight -= 150;
    this.contentHeight = this.contentHeight < 0 ? 0 : this.contentHeight;
    if (document.body.clientWidth <= 768) {
      this.contentHeight -= 30;
    }

    this.onResized.emit(this.contentHeight);
  }
  computedDate(data: Date) {
    let d = new Date(data);
    return d.toLocaleDateString('pt-BR');
  }
}
