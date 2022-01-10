import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProgramadosComponent } from './programados.component';

describe('ProgramadosComponent', () => {
    let component: ProgramadosComponent;
    let fixture: ComponentFixture<ProgramadosComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [ProgramadosComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(ProgramadosComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
