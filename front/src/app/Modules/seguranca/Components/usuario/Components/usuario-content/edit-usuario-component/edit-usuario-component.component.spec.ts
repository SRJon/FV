import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditUsuarioComponentComponent } from './edit-usuario-component.component';

describe('EditUsuarioComponentComponent', () => {
  let component: EditUsuarioComponentComponent;
  let fixture: ComponentFixture<EditUsuarioComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditUsuarioComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditUsuarioComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
