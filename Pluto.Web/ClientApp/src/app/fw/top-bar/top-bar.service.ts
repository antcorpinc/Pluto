import {  Injectable } from '@angular/core';
import { Subject } from 'rxjs/Subject';

@Injectable()
export class TopBarService {
    private appChangeSource = new Subject<null>();
    appChange$ = this.appChangeSource.asObservable();
    constructor() {

    }

    onAppChange($event) : void {
        this.appChangeSource.next($event.target.value);
    }

}
