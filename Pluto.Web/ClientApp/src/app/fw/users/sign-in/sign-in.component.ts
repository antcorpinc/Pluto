import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

import { NgForm } from "@angular/forms";

import {UserApi} from '../user-api';


import {MenuService} from '../../services/menu.service'
import {authenticatedMenuItems} from '../../../app.menu';


@Component({
  selector: 'fw-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  formError: string;
  submitting = false;

  constructor(private userApi:UserApi,
              private router:Router,
              private menuService:MenuService) { }

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
            //ToDO: The authenticated menu items is temporary
            // Need to get it from Service
          this.menuService.items= authenticatedMenuItems;
          //  this.router.navigate(['/dashboard']);
          this.router.navigate(['/authenticated']);
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
