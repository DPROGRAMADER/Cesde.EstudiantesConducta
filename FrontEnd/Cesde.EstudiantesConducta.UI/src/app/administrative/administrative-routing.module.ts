import { NgModule } from '@angular/core';
import { AdministrarConductaEstudianteComponent } from './components/conductaestudiante/administrar-conducta-estudiante/administrar-conducta-estudiante.component';
import { ListarConductaEstudianteComponent } from './components/conductaestudiante/listar-conducta-estudiante/listar-conducta-estudiante.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: `listar-conductaestudiante`,
    component: ListarConductaEstudianteComponent,

  },
  {
    path: `administrar-conductaestudiante`,
    component: AdministrarConductaEstudianteComponent,

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],

})
export class AdministrativeRoutingModule { }
