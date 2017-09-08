import {Observable} from 'rxjs/Observable';

export abstract class UserApi {

 abstract signIn(username:string,password:string,rememberMe:boolean): Observable<any>;

 abstract signOut():Observable<any>;

 abstract isUserAuthenticated():boolean;

 abstract getSignedInUser():string;

 // This is one way of refreshing user
 abstract refreshUser(applicationName?:string):void;

  //signout
  //change password
}
