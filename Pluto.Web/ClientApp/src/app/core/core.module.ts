import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from '@angular/router';
import { AuthenticatedUserComponent } from './authenticated-user/authenticated-user.component';

import {UserService} from './services/user.service';
import {UserApi}  from '../fw/users/user-api';


@NgModule({
  imports: [
    CommonModule,
    RouterModule
  ],
  declarations: [AuthenticatedUserComponent],
   providers: [
    UserService,
    { provide:UserApi,useExisting:UserService }
  ],
})
export class CoreModule { }
