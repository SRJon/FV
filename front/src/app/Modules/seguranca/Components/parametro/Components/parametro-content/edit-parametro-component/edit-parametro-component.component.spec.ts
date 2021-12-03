import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditParametroComponentComponent } from './edit-parametro-component.component';

describe('EditParametroComponentComponent', () => {
  let component: EditParametroComponentComponent;
  let fixture: ComponentFixture<EditParametroComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditParametroComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditParametroComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
