import {Observable} from 'rxjs/Observable';

export abstract class UserApi {

 abstract signIn(username:string,password:string,rememberMe:boolean): Observable<any>;

 abstract signOut():Observable<any>;

 abstract isUserAuthenticated():boolean;

  //signout
  //change password
}
