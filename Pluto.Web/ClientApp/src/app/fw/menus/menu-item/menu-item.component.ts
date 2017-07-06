import { Component,Input, OnInit } from '@angular/core';
import {IMenuItem,MenuService} from '../../services/menu.service';

@Component({
  selector: 'fw-menu-item',
  templateUrl: './menu-item.component.html',
  styleUrls: ['./menu-item.component.css']
})
export class MenuItemComponent implements OnInit {


// Info: the below had to commented bcos of issue with CLI which required i/f in separate file
//@Input() item:MenuItem; // see angular-cli issue #2034
@Input() item=<IMenuItem>null;

  constructor(public menuService:MenuService) { }

  ngOnInit() {
  }

}
