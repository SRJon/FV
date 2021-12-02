import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpresaGridComponent } from './empresa-grid.component';

describe('EmpresaGridComponent', () => {
  let component: EmpresaGridComponent;
  let fixture: ComponentFixture<EmpresaGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpresaGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpresaGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
