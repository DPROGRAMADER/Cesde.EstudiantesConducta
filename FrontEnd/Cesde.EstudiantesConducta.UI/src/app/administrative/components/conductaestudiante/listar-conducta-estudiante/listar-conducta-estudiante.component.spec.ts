import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarConductaEstudianteComponent } from './listar-conducta-estudiante.component';

describe('ListarConductaEstudianteComponent', () => {
  let component: ListarConductaEstudianteComponent;
  let fixture: ComponentFixture<ListarConductaEstudianteComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListarConductaEstudianteComponent]
    });
    fixture = TestBed.createComponent(ListarConductaEstudianteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
