import { TestBed } from '@angular/core/testing';

import { GlobalMenuService } from './global-menu.service';

describe('GlobalMenuService', () => {
  let service: GlobalMenuService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GlobalMenuService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
