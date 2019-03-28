import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Employee } from '../Models/employee.model';

@Injectable()
export class AccountService {

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {
    return this.http.post<any>(environment.endpoint + 'Employee/Login', { username: username, password: password });
  }

  create(employee: Employee) {
    employee.UserName = employee.Email;
    return this.http.post<any>(environment.endpoint + 'Employee/CreateUser', employee);
  }

}
