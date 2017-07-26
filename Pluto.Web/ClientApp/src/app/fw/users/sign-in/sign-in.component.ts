import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

import { NgForm } from "@angular/forms";

import {UserApi} from '../user-api';

@Component({
  selector: 'fw-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  formError: string;
  submitting = false;

  constructor(private userApi:UserApi,
              private router:Router) { }

  ngOnInit() {
  }

  onSubmit(signInForm: NgForm) {

    if (signInForm.valid) {
      console.log('submitting...', signInForm);
      this.submitting = true;
      this.formError = null;

      this.userApi.signIn(signInForm.value.username, signInForm.value.password, signInForm.value.rememberMe)
        .subscribe((data) => {
            console.log('got valid: ', data);
            //ToDO: Get claims for the signed in user
            // Based on that update the menu
            //this.router.navigate(['/authenticated']);
            this.router.navigate(['/dashboard']);
          },
          (err)=> {
            this.submitting = false;
            console.log('got error: ', err);
            this.formError = err;
          }
        );
    }
  }



}
