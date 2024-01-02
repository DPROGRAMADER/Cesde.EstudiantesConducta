import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdministrarConductaEstudianteComponent } from './components/conductaestudiante/administrar-conducta-estudiante/administrar-conducta-estudiante.component';
import { ListarConductaEstudianteComponent } from './components/conductaestudiante/listar-conducta-estudiante/listar-conducta-estudiante.component';


@NgModule({
  declarations: [
    AdministrarConductaEstudianteComponent,
    ListarConductaEstudianteComponent
  ],
  imports: [
    CommonModule
  ]
})
export class AdministrativeModule { }
