import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule} from '@angular/router';
import 'hammerjs';

import { AppComponent } from './app.component';

import {FwModule} from './fw/fw.module';

import {AppRoutingModule,routableComponents} from './app-routing.module';


@NgModule({
  declarations: [
    AppComponent,
    routableComponents
  ],
  imports: [
    BrowserModule,
    FwModule,

   // Info:Make sure the AppRouting is the last module here
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
