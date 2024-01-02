import { Component } from '@angular/core';
import { MessageService } from 'primeng/api';
import { ConfirmDialog } from 'primeng/confirmdialog';
import { conductaEstudiante } from 'src/app/administrative/models/conductaEstudiante';
import { ConductaEstudianteService } from 'src/app/administrative/services/conducta-estudiante.service';

@Component({
  selector: 'app-administrar-conducta-estudiante',
  templateUrl: './administrar-conducta-estudiante.component.html',
  styleUrl: './administrar-conducta-estudiante.component.css'
})
export class AdministrarConductaEstudianteComponent {

  conductaestudiante: conductaEstudiante[] = [];

  constructor(
    private _ConductaEstudianteService: ConductaEstudianteService,
    private _messaService: MessageService,
    private _confirmationService: ConfirmDialog,
  ) { }

  ngOnInit() {

    

  }
}
