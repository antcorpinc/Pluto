import { Component, OnInit } from '@angular/core';

import { NgForm } from "@angular/forms";

@Component({
  selector: 'fw-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  formError: string;
  submitting = false;

  constructor() { }

  ngOnInit() {
  }

  onSubmit(signInForm: NgForm) {
  }

}
