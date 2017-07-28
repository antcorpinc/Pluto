import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from '@angular/router';
import { AuthenticatedUserComponent } from './authenticated-user/authenticated-user.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule
  ],
  declarations: [AuthenticatedUserComponent]
})
export class CoreModule { }
