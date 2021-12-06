import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpresaContentComponent } from './empresa-content.component';

describe('EmpresaContentComponent', () => {
  let component: EmpresaContentComponent;
  let fixture: ComponentFixture<EmpresaContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmpresaContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpresaContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
