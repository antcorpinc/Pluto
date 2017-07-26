import {NgModule} from '@angular/core';
import { Routes,RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsComponent } from './settings/settings.component';
import {CountryListComponent} from './country-list/country-list.component';
import {CountryDetailComponent} from './country-detail/country-detail.component';
import {CountryMaintComponent} from './country-maint/country-maint.component';
import {SignInComponent} from './fw/users/sign-in/sign-in.component';
import {RegisterUserComponent} from './register/register-user/register-user.component';
import {HomeComponent} from './home/home/home.component';

export const routes: Routes = [
   { path: 'dashboard', component: DashboardComponent },
   { path: 'sigin', component:SignInComponent},
   { path: 'country-list/:count', component: CountryListComponent },
   { path: 'country-detail/:country', component: CountryDetailComponent },
   { path: 'country-maint', component: CountryMaintComponent },
   { path: 'settings', component: SettingsComponent },
   { path:'register-user',component:RegisterUserComponent},
   { path: '', component: HomeComponent },
   { path: '**', component: HomeComponent }
];



@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }

export const routableComponents =[
  DashboardComponent,
  CountryListComponent,
  CountryDetailComponent,
  CountryMaintComponent,
  SettingsComponent,
  RegisterUserComponent
];

