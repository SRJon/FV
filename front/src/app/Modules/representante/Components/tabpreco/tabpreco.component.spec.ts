import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabprecoComponent } from './tabpreco.component';

describe('TabprecoComponent', () => {
  let component: TabprecoComponent;
  let fixture: ComponentFixture<TabprecoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TabprecoComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TabprecoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
