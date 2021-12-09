import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiretorioGridComponent } from './diretorio-grid.component';

describe('DiretorioGridComponent', () => {
  let component: DiretorioGridComponent;
  let fixture: ComponentFixture<DiretorioGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiretorioGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiretorioGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
