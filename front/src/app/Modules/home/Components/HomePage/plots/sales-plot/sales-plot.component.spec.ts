import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesPlotComponent } from './sales-plot.component';

describe('SalesPlotComponent', () => {
    let component: SalesPlotComponent;
    let fixture: ComponentFixture<SalesPlotComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [SalesPlotComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(SalesPlotComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
