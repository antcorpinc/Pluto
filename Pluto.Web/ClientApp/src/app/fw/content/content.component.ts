import { Component, OnInit } from '@angular/core';
import {MenuService} from '../services/menu.service';
import {ScreenService} from '../services/screen.service';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'fw-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit {

  constructor(public menuService: MenuService,
              public screenService: ScreenService) { }

  ngOnInit() {
  }

}
