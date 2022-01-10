import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FinanceiroGridComponent } from './financeiro-grid.component';

describe('FinanceiroGridComponent', () => {
    let component: FinanceiroGridComponent;
    let fixture: ComponentFixture<FinanceiroGridComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [FinanceiroGridComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(FinanceiroGridComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
