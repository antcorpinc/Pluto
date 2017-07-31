import {Observable} from 'rxjs/Observable';

export abstract class UserApi {

 abstract signIn(username:string,password:string,rememberMe:boolean): Observable<any>;

 abstract signOut():Observable<any>;

  //signout
  //change password
}
