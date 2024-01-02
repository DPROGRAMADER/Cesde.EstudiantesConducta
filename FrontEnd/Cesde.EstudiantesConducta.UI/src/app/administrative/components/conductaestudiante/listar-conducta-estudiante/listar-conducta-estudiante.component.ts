import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { ConfirmationService, } from 'primeng/api';
import { conductaEstudiante } from 'src/app/administrative/models/conductaEstudiante';
import { ConductaEstudianteService } from 'src/app/administrative/services/conducta-estudiante.service';

@Component({
  selector: 'app-listar-conducta-estudiante',
  templateUrl: './listar-conducta-estudiante.component.html',
  styleUrl: './listar-conducta-estudiante.component.css'
})
export class ListarConductaEstudianteComponent {

  conductaestudiante: conductaEstudiante[] = [];

  constructor(
    private _ConductaEstudianteService: ConductaEstudianteService,
    private _messageService: MessageService,
    private router: Router,
    private _confirmationService: ConfirmationService
  ) { }

  ngOnInit() {

  }
  //Listar Conducta estudiante
  ListarConductaEstudiante() {
    this._ConductaEstudianteService.getEstudianteController().subscribe({
      next: (data) => {
        this.conductaestudiante = data
      }
    })
  }
  //Eliminar Conducta estudiante
  EliminarConductaEstudiante(id: number, event: Event) {
    this._confirmationService.confirm({
      target: event.target!,
      header: `Confirmacion`,
      acceptLabel: `Si`,
      rejectLabel: `No`,
      message: `¿Desea Eliminar El registro?`,
      icon: `pi pi- exclamation-triangle`,
      accept: () => {
        this._ConductaEstudianteService.deleteEstudianteController(id).subscribe({
          next: (data) => {
            this._messageService.add({
              severity: 'warn',
              summary: `Eliminacion exitosa`,
              detail: ""
            });
            this.ListarConductaEstudiante();
          },
          error: (error) => {
            if (error.status == 500) {
              this._messageService.add({
                severity: 'info',
                summary: `Error en el servidor`,
                detail: ""
              });

            } else {
              this._messageService.add({
                severity: 'error',
                summary: `Se produjo un error en la eliminacion`,
              });
            }
          }
        });
      },
      reject: () => { }
    })
  }

  nuevaConductaEstudiante() {
    this.router.navigate(['conductaEstudiante', 'new'])
  }
  editarConductaEstudiante(id: number) {
    this.router.navigate([`administrar-conductaestudiante/${id}`]);
  }
}






