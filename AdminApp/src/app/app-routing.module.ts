import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';

const FullRoutes: Routes = [
  {
    path: 'dashboard',
    loadChildren: './dashboard/dashboard.module#DashboardModule'
  },
  {
    path: 'practices',
    loadChildren: './practices/practices.module#PracticesModule'
  }
];

const appRoutes: Routes = [
  {
    path: 'account',
    loadChildren: './account/account.module#AccountModule'
  },
  { path: '', redirectTo: '/account/login', pathMatch: 'full' },
  { path: '', component: MainLayoutComponent, children: FullRoutes },
  { path: '**', redirectTo: '/dashboard', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
