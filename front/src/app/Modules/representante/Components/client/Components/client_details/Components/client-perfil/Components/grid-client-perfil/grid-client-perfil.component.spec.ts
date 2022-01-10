import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GridClientPerfilComponent } from './grid-client-perfil.component';

describe('GridClientPerfilComponent', () => {
  let component: GridClientPerfilComponent;
  let fixture: ComponentFixture<GridClientPerfilComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GridClientPerfilComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GridClientPerfilComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
