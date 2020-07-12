import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarsalasComponent } from './listarsalas.component';

describe('ListarsalasComponent', () => {
  let component: ListarsalasComponent;
  let fixture: ComponentFixture<ListarsalasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarsalasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarsalasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
