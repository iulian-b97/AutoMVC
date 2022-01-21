import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';
import { NavBarComponent } from './nav/nav-bar.component';
import { ContactComponent } from './contact/contact.component';


@NgModule({
    declarations: [
        NavBarComponent,  
        ContactComponent      
    ],
    imports: [
      CommonModule,
      AppRoutingModule,
    ],
    exports: [
        NavBarComponent,
        ContactComponent
    ]
  })
  export class SharedModule { }

