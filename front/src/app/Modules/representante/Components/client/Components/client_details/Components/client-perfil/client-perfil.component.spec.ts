import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientPerfilComponent } from './client-perfil.component';

describe('ClientPerfilComponent', () => {
  let component: ClientPerfilComponent;
  let fixture: ComponentFixture<ClientPerfilComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientPerfilComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientPerfilComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
