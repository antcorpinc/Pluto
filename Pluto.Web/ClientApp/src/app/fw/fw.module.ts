import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import {RouterModule} from '@angular/router';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MdInputModule} from '@angular/material';

import { FrameworkBodyComponent } from './framework-body/framework-body.component';
import { ContentComponent } from './content/content.component';
import { TitleBarComponent } from './title-bar/title-bar.component';
import { FrameworkConfigService} from './services/framework-config.service';
import { TopBarComponent } from './top-bar/top-bar.component';
import { StatusBarComponent } from './status-bar/status-bar.component';
import {ScreenService} from './services/screen.service';
import {MenuService} from './services/menu.service';
import { MenuComponent } from './menus/menu/menu.component';
import { MenuItemComponent } from './menus/menu-item/menu-item.component';
import { PopupMenuComponent } from './menus/popup-menu/popup-menu.component';
import { SignInComponent } from './users/sign-in/sign-in.component';
import { PanelComponent } from './panels/panel/panel.component';

import {TopBarService} from './top-bar/top-bar.service';
@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    BrowserAnimationsModule,
    MdInputModule
  ],
  declarations: [
    FrameworkBodyComponent,
    ContentComponent,
    TitleBarComponent,
    TopBarComponent,
    StatusBarComponent,
    MenuComponent,
    MenuItemComponent,
    PopupMenuComponent,
    SignInComponent,
    PanelComponent],

  providers:[
    FrameworkConfigService,
    ScreenService,
    MenuService,
    TopBarService
    ],

  exports:[
    FrameworkBodyComponent,
    PanelComponent,
    MdInputModule
  ]

})
export class FwModule { }
