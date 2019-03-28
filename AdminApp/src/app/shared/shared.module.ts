import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopbarComponent } from './topbar/topbar.component';
import { SidebarComponent } from './sidebar/sidebar.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [TopbarComponent, SidebarComponent],
  exports: [TopbarComponent, SidebarComponent]
})
export class SharedModule { }
