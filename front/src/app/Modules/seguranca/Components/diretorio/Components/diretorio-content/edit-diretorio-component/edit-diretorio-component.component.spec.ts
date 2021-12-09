import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditDiretorioComponentComponent } from './edit-diretorio-component.component';

describe('EditDiretorioComponentComponent', () => {
  let component: EditDiretorioComponentComponent;
  let fixture: ComponentFixture<EditDiretorioComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditDiretorioComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditDiretorioComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
