import { Injectable } from '@angular/core';

export interface IMenuItem{
  text:string;
  icon:string;
  route:string;
  submenu:Array<IMenuItem>;
}


@Injectable()
export class MenuService {

  items:Array<IMenuItem>;
  isVertical=false; //Info: When true menu on left nav instead of title bar
  // This flasg indicates whether we are small screen and if true then show left side menu
  showingLeftSideMenu=false;

  constructor() { }

  toggleLeftSideMenu() : void {
    this.isVertical=true;
    this.showingLeftSideMenu = !this.showingLeftSideMenu;
  }
}
