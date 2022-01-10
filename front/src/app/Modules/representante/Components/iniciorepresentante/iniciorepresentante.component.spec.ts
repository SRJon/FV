import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IniciorepresentanteComponent } from './iniciorepresentante.component';

describe('IniciorepresentanteComponent', () => {
    let component: IniciorepresentanteComponent;
    let fixture: ComponentFixture<IniciorepresentanteComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [IniciorepresentanteComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(IniciorepresentanteComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
