import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AccountService } from '../account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  RegisterForm: FormGroup;
  submitted = false;
  loading = false;

  constructor(private formBuilder: FormBuilder, private accountService: AccountService, private toasterService: ToastrService) { }

  ngOnInit() {
    const body = document.body;
    body.classList.add('bg-dark');

    this.RegisterForm = this.formBuilder.group({
      FirstName: ['', Validators.required],
      LastName: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      Password: ['', [Validators.required, Validators.minLength(8)]],
      ConfirmPassword: ['', [Validators.required, Validators.minLength(8)]],
    });
  }

  get f() {
    return this.RegisterForm.controls;
  }

  onSubmit() {
    this.submitted = true;
    if (this.RegisterForm.invalid) {
      return;
    } else {
      if (this.f.Password.value === this.f.ConfirmPassword.value) {
        this.loading = true;
        this.accountService.create(this.RegisterForm.value).subscribe(
          data => {
            if (data && data.success && data.message.indexOf('Successfully')) {
              this.toasterService.success(data.message, 'Success');
              this.RegisterForm.reset();
            } else {
              this.toasterService.error(data.message, 'Failure');
            }
            this.loading = false;
          }, error => {
            this.loading = false;
            this.toasterService.error('Something went wrong.', 'Failure');
          });
      } else {
        this.toasterService.error('Password does not match.', 'Failure');
      }
    }
  }

}
