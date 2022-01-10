import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EstoqueContentComponent } from './estoque-content.component';

describe('EstoqueContentComponent', () => {
    let component: EstoqueContentComponent;
    let fixture: ComponentFixture<EstoqueContentComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [EstoqueContentComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(EstoqueContentComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
