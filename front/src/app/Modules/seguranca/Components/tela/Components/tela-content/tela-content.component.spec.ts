import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TelaContentComponent } from './tela-content.component';

describe('TelaContentComponent', () => {
  let component: TelaContentComponent;
  let fixture: ComponentFixture<TelaContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TelaContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TelaContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
