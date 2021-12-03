import { TestBed } from '@angular/core/testing';

import { ADVGFRPVService } from './ad-vgfrpv.service';

describe('ADVGFRPVService', () => {
  let service: ADVGFRPVService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ADVGFRPVService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
