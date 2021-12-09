import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParametroContentComponent } from './parametro-content.component';

describe('ParametroContentComponent', () => {
  let component: ParametroContentComponent;
  let fixture: ComponentFixture<ParametroContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParametroContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ParametroContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
