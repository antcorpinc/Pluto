import { Component, OnInit } from '@angular/core';
import {ScreenService} from '../services/screen.service';
import {MenuService} from '../services/menu.service';
import { UserApi} from '../users/user-api';

@Component({
  selector: 'fw-title-bar',
  templateUrl: './title-bar.component.html',
  styleUrls: ['./title-bar.component.scss']
})
export class TitleBarComponent implements OnInit {

  //Info: Add public members in () when their properties needed in
  // template -- Needed for AOT
  constructor(public screenService:ScreenService,
  public menuService:MenuService,
  public userApi:UserApi) { }

  ngOnInit() {
  }

}
