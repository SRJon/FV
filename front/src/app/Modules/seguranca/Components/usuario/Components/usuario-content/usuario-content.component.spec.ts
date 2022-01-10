import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioContentComponent } from './usuario-content.component';

describe('UsuarioContentComponent', () => {
  let component: UsuarioContentComponent;
  let fixture: ComponentFixture<UsuarioContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UsuarioContentComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
