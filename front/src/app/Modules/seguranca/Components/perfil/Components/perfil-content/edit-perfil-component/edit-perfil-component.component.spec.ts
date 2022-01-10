import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPerfilComponentComponent } from './edit-perfil-component.component';

describe('EditPerfilComponentComponent', () => {
  let component: EditPerfilComponentComponent;
  let fixture: ComponentFixture<EditPerfilComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditPerfilComponentComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditPerfilComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
