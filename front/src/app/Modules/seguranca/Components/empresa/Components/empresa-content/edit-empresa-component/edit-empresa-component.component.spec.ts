import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditEmpresaComponentComponent } from './edit-empresa-component.component';

describe('EditEmpresaComponentComponent', () => {
    let component: EditEmpresaComponentComponent;
    let fixture: ComponentFixture<EditEmpresaComponentComponent>;

    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [EditEmpresaComponentComponent],
        }).compileComponents();
    });

    beforeEach(() => {
        fixture = TestBed.createComponent(EditEmpresaComponentComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
