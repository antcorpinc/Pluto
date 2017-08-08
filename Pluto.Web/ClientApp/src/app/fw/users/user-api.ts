import {Observable} from 'rxjs/Observable';

export abstract class UserApi {

 abstract signIn(username:string,password:string,rememberMe:boolean): Observable<any>;

 abstract signOut():Observable<any>;

 abstract isUserAuthenticated():boolean;

 abstract getSignedInUser():string;

  //signout
  //change password
}
