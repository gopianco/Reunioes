import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SalaComponentComponent } from './sala-component.component';

describe('SalaComponentComponent', () => {
  let component: SalaComponentComponent;
  let fixture: ComponentFixture<SalaComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalaComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalaComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
