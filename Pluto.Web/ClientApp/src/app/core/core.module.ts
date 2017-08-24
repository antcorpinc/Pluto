import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from '@angular/router';
import { AuthenticatedUserComponent } from './authenticated-user/authenticated-user.component';

import {UserService} from './services/user.service';
import {AuthGuardService} from './services/auth-guard.service';

import {UserApi}  from '../fw/users/user-api';
import {AppDataService} from './services/app-data.service';
import {ImagePanelComponent} from './panels/image-panel/image-panel.component';
import {FwModule} from '../fw/fw.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FwModule
  ],
  declarations: [
    AuthenticatedUserComponent,
    ImagePanelComponent
  ],
   providers: [
    UserService,
    { provide:UserApi,useExisting:UserService },
    AuthGuardService,
    AppDataService
  ],
  exports:[
    ImagePanelComponent
  ]
})
export class CoreModule { }
