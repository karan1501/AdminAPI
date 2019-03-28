import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PracticesRoutingModule } from './practices-routing.module';
import { DirectiveTestComponent } from './directive-test/directive-test.component';
import { CustomNgIfDirective } from '../Directives/custom-ng-if.directive';
import { CustomDirective } from '../Directives/custom.directive';

@NgModule({
  imports: [
    CommonModule,
    PracticesRoutingModule
  ],
  declarations: [
    DirectiveTestComponent,
    CustomNgIfDirective,
    CustomDirective,
  ]
})
export class PracticesModule { }
