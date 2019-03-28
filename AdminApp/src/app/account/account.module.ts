import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AccountService } from './account.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    AccountRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  declarations: [LoginComponent, RegisterComponent, ForgotPasswordComponent],
  providers: [AccountService]
})
export class AccountModule { }
