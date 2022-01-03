import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportEstoqueComponentComponent } from './report-estoque-component.component';

describe('ReportEstoqueComponentComponent', () => {
  let component: ReportEstoqueComponentComponent;
  let fixture: ComponentFixture<ReportEstoqueComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportEstoqueComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportEstoqueComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
