import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RefactorPasswordComponent } from './refactor-password.component';

describe('RefactorPasswordComponent', () => {
    let component: RefactorPasswordComponent;
    let fixture: ComponentFixture<RefactorPasswordComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [RefactorPasswordComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(RefactorPasswordComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
