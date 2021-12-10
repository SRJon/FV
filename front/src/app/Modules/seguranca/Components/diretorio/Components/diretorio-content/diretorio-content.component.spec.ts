import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiretorioContentComponent } from './diretorio-content.component';

describe('DiretorioContentComponent', () => {
  let component: DiretorioContentComponent;
  let fixture: ComponentFixture<DiretorioContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiretorioContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiretorioContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
