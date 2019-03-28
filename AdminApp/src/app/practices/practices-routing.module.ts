import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DirectiveTestComponent } from './directive-test/directive-test.component';

const routes: Routes = [
  {
    path: 'directive-test',
    component: DirectiveTestComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PracticesRoutingModule { }
