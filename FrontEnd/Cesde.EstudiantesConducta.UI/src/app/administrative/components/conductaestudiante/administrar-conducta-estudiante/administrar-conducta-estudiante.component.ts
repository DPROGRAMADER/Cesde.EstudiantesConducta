import { Component } from '@angular/core';
import { conductaEstudiante } from 'src/app/administrative/models/conductaEstudiante';
import { ConductaEstudianteService } from 'src/app/administrative/services/conducta-estudiante.service';


@Component({
  selector: 'app-administrar-conducta-estudiante',
  templateUrl: './administrar-conducta-estudiante.component.html',
  styleUrls: ['./administrar-conducta-estudiante.component.css']
})
export class AdministrarConductaEstudianteComponent {

  conductaEstudiante: conductaEstudiante[] = [];


  constructor(
    private_conductaestudianteservice: ConductaEstudianteService,
    
  ) {


  }

}
