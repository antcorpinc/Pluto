import { Component, OnInit } from '@angular/core';
import {FrameworkConfigService} from '../services/framework-config.service';
import { UserApi} from '../users/user-api';
import { Subject } from 'rxjs/Subject';

import {TopBarService} from './top-bar.service';

export interface ILanguage{
  name:string;
  id:number;
}

@Component({
  selector: 'fw-top-bar',
  templateUrl: './top-bar.component.html',
  styleUrls: ['./top-bar.component.css']
})
export class TopBarComponent implements OnInit {

  languages:ILanguage[];
  private appChangeSource = new Subject<null>();
  appChange$ = this.appChangeSource.asObservable();

  //Info: Need to inject as public since its properties are used in template for AOT
  constructor(public frameworkConfigService:FrameworkConfigService,
  public userApi:UserApi,public topBarService:TopBarService) { }

  ngOnInit() {
    this.getLanguages();
  }

  signOut(){
    this.userApi.signOut();
  }

  getLanguages(){
   this.languages= [
     {id:1, name:'English'},
     {id:2, name:'Marathi'},
    ] ;
  }

  onApplicationChange($event){
    alert($event.target.value);
   // this.appChangeSource.next($event.target.value);
   // This is one way of refreshing user
  //  this.userApi.refreshUser();
  // This is second way of updating using event based.
  this.topBarService.onAppChange($event);
    }
}
