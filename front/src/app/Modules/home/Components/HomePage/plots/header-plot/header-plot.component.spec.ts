import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderPlotComponent } from './header-plot.component';

describe('HeaderPlotComponent', () => {
  let component: HeaderPlotComponent;
  let fixture: ComponentFixture<HeaderPlotComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeaderPlotComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HeaderPlotComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
