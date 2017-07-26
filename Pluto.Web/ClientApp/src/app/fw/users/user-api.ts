import {Observable} from 'rxjs/Observable';

export abstract class UserApi {

 abstract signIn(username:string,password:string,rememberMe:boolean): Observable<any>;

  //signout
  //change password
}
