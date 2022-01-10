import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTelaComponentComponent } from './edit-tela-component.component';

describe('EditTelaComponentComponent', () => {
  let component: EditTelaComponentComponent;
  let fixture: ComponentFixture<EditTelaComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditTelaComponentComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditTelaComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
