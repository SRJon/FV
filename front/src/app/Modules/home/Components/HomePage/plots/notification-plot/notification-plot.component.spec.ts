import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotificationPlotComponent } from './notification-plot.component';

describe('NotificationPlotComponent', () => {
    let component: NotificationPlotComponent;
    let fixture: ComponentFixture<NotificationPlotComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [NotificationPlotComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(NotificationPlotComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
