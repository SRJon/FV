import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PedidoandamentoComponent } from './pedidoandamento.component';

describe('PedidoandamentoComponent', () => {
  let component: PedidoandamentoComponent;
  let fixture: ComponentFixture<PedidoandamentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PedidoandamentoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PedidoandamentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
