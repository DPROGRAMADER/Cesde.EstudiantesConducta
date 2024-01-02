import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdministrarConductaEstudianteComponent } from './administrar-conducta-estudiante.component';

describe('AdministrarConductaEstudianteComponent', () => {
  let component: AdministrarConductaEstudianteComponent;
  let fixture: ComponentFixture<AdministrarConductaEstudianteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdministrarConductaEstudianteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AdministrarConductaEstudianteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
