import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { UserApi } from '../../fw/users/user-api';
import { Router } from '@angular/router';
import {MenuService} from '../../fw/services/menu.service';
import {initialMenuItems,authenticatedMenuItems}
         from '../../app.menu';

@Injectable()
export class UserService implements UserApi {
  refreshUser(applicationName?:string): void {
    this.menuService.items= authenticatedMenuItems;
  }


  isAuthenticated =false;
  private signedInUser='';

  constructor(private router:Router,
    private menuService:MenuService) { }

  signIn(username: string, password: string, rememberMe: boolean):
  Observable<any> {
    console.log('UserService.signIn: ' + username + ' ' + password + ' ' + rememberMe);
    this.isAuthenticated = true;
    this.signedInUser = username;
    this.menuService.items= authenticatedMenuItems;
    return Observable.of({}).delay(2000);
  }

  signOut(): Observable<any> {
     this.isAuthenticated=false;
     this.signedInUser = '';
     this.menuService.items= initialMenuItems;
    this.router.navigate(['/home']);
    return Observable.of({});
  }

  isUserAuthenticated(): boolean {
    return this.isAuthenticated;
  }

  getSignedInUser(): string {
   return this.signedInUser;
  }
}
