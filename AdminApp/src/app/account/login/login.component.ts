import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AccountService } from '../account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  loading = false;
  submitted = false;

  constructor(private formBuilder: FormBuilder, private router: Router, private accountService: AccountService
    , private toastr: ToastrService) { }

  ngOnInit() {
    const body = document.body;
    body.classList.add('bg-dark');

    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }

  onSubmit() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }

    this.loading = true;
    this.accountService.login(this.f.username.value, this.f.password.value)
      .subscribe(
        data => {
          if (data.success) {
            this.router.navigate(['/dashboard']);
            localStorage.setItem('token', data.access_token);
          } else {
            this.toastr.error(data.message, 'Error');
          }
          this.loading = false;
        },
        error => {
          this.loading = false;
        });
  }

}
