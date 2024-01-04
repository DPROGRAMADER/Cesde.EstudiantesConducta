import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TableModule } from 'primeng/table';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ButtonModule } from 'primeng/button';
import { RouterModule } from '@angular/router';
import { AdministrativeRoutingModule } from './administrative-routing.module';
import { ListarComponent } from './components/listar/listar.component';

@NgModule({
  declarations: [
    ListarComponent
  ],
  imports: [
    CommonModule,
    TableModule,
    ToastModule,
    ConfirmDialogModule,
    ButtonModule,
    RouterModule
  ],
  exports: [AdministrativeRoutingModule]
})
export class AdministrativeModule { }
