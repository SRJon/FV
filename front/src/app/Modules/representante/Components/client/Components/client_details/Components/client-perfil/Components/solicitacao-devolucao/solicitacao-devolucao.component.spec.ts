import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitacaoDevolucaoComponent } from './solicitacao-devolucao.component';

describe('SolicitacaoDevolucaoComponent', () => {
  let component: SolicitacaoDevolucaoComponent;
  let fixture: ComponentFixture<SolicitacaoDevolucaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolicitacaoDevolucaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitacaoDevolucaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
