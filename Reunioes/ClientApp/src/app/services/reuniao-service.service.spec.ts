import { TestBed, inject } from '@angular/core/testing';

import { Services\reuniaoServiceService } from './services\reuniao-service.service';

describe('Services\reuniaoServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [Services\reuniaoServiceService]
    });
  });

  it('should be created', inject([Services\reuniaoServiceService], (service: Services\reuniaoServiceService) => {
    expect(service).toBeTruthy();
  }));
});
