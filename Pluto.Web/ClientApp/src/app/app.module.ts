import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import 'hammerjs';

import {FwModule} from './fw/fw.module';
import {HomeModule} from './home/home.module';

import { AppComponent } from './app.component';
import {AppRoutingModule,routableComponents} from './app-routing.module';



@NgModule({
  declarations: [
    AppComponent,
    routableComponents
  ],
  imports: [
    BrowserModule,
    FwModule,
    HomeModule,
   // Info:Make sure the AppRouting is the last module here
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
