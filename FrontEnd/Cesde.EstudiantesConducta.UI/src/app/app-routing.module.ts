import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';
import { AdministrativeModule } from './administrative/administrative.module';

const routes: Routes = [];

@NgModule({
  declarations: [],
  imports: [
    AdministrativeModule,
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
