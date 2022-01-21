import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AuthenticationComponent } from './authentication/authentication.component';
import { UserAccountComponent } from './user-account/user-account.component';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { DetailsAccountComponent } from './user-account/view-account/view-account.component';
import { EditCountryComponent } from './user-account/edit-account/edit-country/edit-country.component';
import { EditNameComponent } from './user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './user-account/edit-account/edit-username/edit-username.component';


@NgModule({
    declarations: [
        AuthenticationComponent,
        UserAccountComponent,
        LoginComponent,
        RegisterComponent,
        DetailsAccountComponent,
        EditCountryComponent,
        EditNameComponent,
        EditPhoneComponent,
        EditUsernameComponent
    ],
    imports: [
      CommonModule,
      AppRoutingModule,
      FormsModule,
      ReactiveFormsModule
    ]
  })
  export class IdentitytModule { }