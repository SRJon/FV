import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiretorioComponent } from './diretorio.component';

describe('DiretorioComponent', () => {
  let component: DiretorioComponent;
  let fixture: ComponentFixture<DiretorioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DiretorioComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiretorioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
