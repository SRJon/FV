import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParametroGridComponent } from './parametro-grid.component';

describe('ParametroGridComponent', () => {
  let component: ParametroGridComponent;
  let fixture: ComponentFixture<ParametroGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParametroGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ParametroGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
