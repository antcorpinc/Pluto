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

  constructor() { }

}
