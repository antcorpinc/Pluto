import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import 'hammerjs';

import {FwModule} from './fw/fw.module';
import {HomeModule} from './home/home.module';
import {DashboardModule} from './dashboard/dashboard.module';
import {CoreModule} from './core/core.module';
import { AppComponent } from './app.component';
import {AppRoutingModule,routableComponents} from './app-routing.module';

//import {UserService} from './services/user.service';
//import {UserApi}  from './fw/users/user-api';


@NgModule({
  declarations: [
    AppComponent,
    routableComponents
  ],
  imports: [
    BrowserModule,
    FwModule,
    HomeModule,
    DashboardModule,
    CoreModule,
   // Info:Make sure the AppRouting is the last module here
    AppRoutingModule
  ],
  providers: [
//    UserService,
  //  { provide:UserApi,useExisting:UserService }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
