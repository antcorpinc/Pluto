import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule} from '@angular/router';
import 'hammerjs';

import { AppComponent } from './app.component';

import {FwModule} from './fw/fw.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsComponent } from './settings/settings.component';
import {appRoutes} from './app.routing';
import { CountryListComponent } from './country-list/country-list.component';
import { CountryMaintComponent } from './country-maint/country-maint.component';
import { CountryDetailComponent } from './country-detail/country-detail.component';
import { RegisterUserComponent } from './register/register-user/register-user.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,

    SettingsComponent,
    CountryListComponent,
    CountryMaintComponent,
    CountryDetailComponent,
    RegisterUserComponent
  ],
  imports: [
    BrowserModule,
    FwModule,
    RouterModule.forRoot(appRoutes)

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
