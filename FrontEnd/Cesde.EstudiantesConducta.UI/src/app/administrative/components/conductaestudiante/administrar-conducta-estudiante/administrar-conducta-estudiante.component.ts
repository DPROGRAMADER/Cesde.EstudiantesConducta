import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router, } from '@angular/router';
import { MessageService } from 'primeng/api';
import { conductaEstudiante } from 'src/app/administrative/models/conductaEstudiante';
import { ConductaEstudianteService } from 'src/app/administrative/services/conducta-estudiante.service';

@Component({
  selector: 'app-administrar-conducta-estudiante',
  templateUrl: './administrar-conducta-estudiante.component.html',
  styleUrl: './administrar-conducta-estudiante.component.css'
})
export class AdministrarConductaEstudianteComponent {

  NombrePagina: string = "Crear Conducta Estudiante";
  id: number = 0;
  form: FormGroup;
  conductaestudiante: conductaEstudiante[] = [];

  constructor(
    private fb: FormBuilder,
    private activateRoute: ActivatedRoute,
    private router: Router,
    private _ConductaEstudianteService: ConductaEstudianteService,
    private _messaService: MessageService,
  ) {
    this.form = this.fb.group({
      id: [],
      Documento: [],
      PrimerNombre: [],
      SegundoNombre: [],
      ProgramaAcademico: [],
      Observaciones: [],
      FechaNovedad: [],
    })

  }
//Editar Conducta estudiante
  ngOninit() {
    let id = this.activateRoute.snapshot.paramMap.get('id');
    this.id = Number(id);
    if (this.id) {
      this.NombrePagina = 'EDITAR CONDUCTA ESTUDIANTE'
      this._ConductaEstudianteService.getEstudianteController()
        .subscribe({
          next: (data) => {
            this.form.setValue(data);
          },
          error: (error) => {
            this._messaService.add({
              severity: 'info',
              summary: 'Error en el servidor',
              detail: 'Error en la carga de datos',
            });
          },
        });
    }
  }
// Crear Conducta estudiante
  crearConductaEstudiante(form: conductaEstudiante) {
    let mensaje: string;
    if (this.id) {
      mensaje = 'Se registro Correctamente.';
      this._ConductaEstudianteService.putEstudianteController(form)
        .subscribe({
          next: (data) => {
            this._messaService.add({
              severity: 'info',
              summary: 'mensaje',
              detail: '',
            })
          },
          error: (error) => {
            this._messaService.add({
              severity: 'error',
              summary: 'Error al editar los datos',
              detail: '',
            });
          },
        });
    } else {
      mensaje = 'Registro creado correctamente';
      this._ConductaEstudianteService.postEstudianteController(form)
        .subscribe({
          next: (data) => {
            this._messaService.add({
              severity: 'success',
              summary: 'mensaje',
              detail: '',
            });
          },

          error: (error) => {
            this._messaService.add({
              severity: 'error',
              summary: 'error al guardar los datos',
              detail: '',
            })
          }
        });
      this.form.markAllAsTouched();
    }
  }

  atras() {
    this.router.navigate(['listar-conductaestudiante']);
  }
}
