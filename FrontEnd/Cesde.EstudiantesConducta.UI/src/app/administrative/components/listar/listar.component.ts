import { Component, OnInit } from '@angular/core';
import { conductaEstudiante } from '../../models/conductaEstudiante';
import { ConductaEstudianteService } from '../../services/conducta-estudiante.service';
import { ConfirmationService, MessageService } from 'primeng/api';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrl: './listar.component.css'
})
export class ListarComponent implements OnInit {
  conductaestudiante: conductaEstudiante[] = [];
  rowsPerPage = 5

  constructor(
    private _ConductaEstudianteService: ConductaEstudianteService,
    private _messageService: MessageService,
    private router: Router,
    private _confirmationService: ConfirmationService
  ) { }

 
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
  ngOnInit(): void {
    this.ListarConductaEstudiante();
  }

}
