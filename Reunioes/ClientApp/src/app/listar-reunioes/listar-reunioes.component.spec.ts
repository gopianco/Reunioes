import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarReunioesComponent } from './listar-reunioes.component';

describe('ListarReunioesComponent', () => {
  let component: ListarReunioesComponent;
  let fixture: ComponentFixture<ListarReunioesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarReunioesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarReunioesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
