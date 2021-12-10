import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GridNotaFiscalComponent } from './grid-nota-fiscal.component';

describe('GridNotaFiscalComponent', () => {
  let component: GridNotaFiscalComponent;
  let fixture: ComponentFixture<GridNotaFiscalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GridNotaFiscalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GridNotaFiscalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
