import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AutorizacaoretiradaComponent } from './autorizacaoretirada.component';

describe('AutorizacaoretiradaComponent', () => {
    let component: AutorizacaoretiradaComponent;
    let fixture: ComponentFixture<AutorizacaoretiradaComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [AutorizacaoretiradaComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(AutorizacaoretiradaComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
