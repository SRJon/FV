import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GridSolicitacaoDevolucaoComponent } from './grid-solicitacao-devolucao.component';

describe('GridSolicitacaoDevolucaoComponent', () => {
    let component: GridSolicitacaoDevolucaoComponent;
    let fixture: ComponentFixture<GridSolicitacaoDevolucaoComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [GridSolicitacaoDevolucaoComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(GridSolicitacaoDevolucaoComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
