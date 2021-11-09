import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TelaGridComponent } from './tela-grid.component';

describe('TelaGridComponent', () => {
  let component: TelaGridComponent;
  let fixture: ComponentFixture<TelaGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TelaGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TelaGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
