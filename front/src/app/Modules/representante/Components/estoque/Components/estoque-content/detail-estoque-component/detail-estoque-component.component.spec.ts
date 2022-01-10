import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailEstoqueComponentComponent } from './detail-estoque-component.component';

describe('DetailEstoqueComponentComponent', () => {
    let component: DetailEstoqueComponentComponent;
    let fixture: ComponentFixture<DetailEstoqueComponentComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [DetailEstoqueComponentComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(DetailEstoqueComponentComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
