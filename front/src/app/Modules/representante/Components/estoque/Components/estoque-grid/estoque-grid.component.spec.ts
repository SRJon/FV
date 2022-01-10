import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EstoqueGridComponent } from './estoque-grid.component';

describe('EstoqueGridComponent', () => {
  let component: EstoqueGridComponent;
  let fixture: ComponentFixture<EstoqueGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EstoqueGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EstoqueGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
