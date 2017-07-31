import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { UserApi } from '../../fw/users/user-api';
import { Router } from '@angular/router';

@Injectable()
export class UserService implements UserApi {

  isAuthenticated =false;
  signIn(username: string, password: string, rememberMe: boolean):
  Observable<any> {
    console.log('UserService.signIn: ' + username + ' ' + password + ' ' + rememberMe);
    this.isAuthenticated = true;
    return Observable.of({}).delay(2000);
  }
}
