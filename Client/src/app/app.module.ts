import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './common/contact/contact.component';
import { NavBarComponent } from './common/nav/nav-bar.component';
import { LoginComponent } from './identityManagement/user/login/login.component';
import { RegisterComponent } from './identityManagement/user/register/register.component';
import { DetailsAccountComponent } from './identityManagement/user/user-account/edit-account/details-account/details-account.component';
import { EditCountryComponent } from './identityManagement/user/user-account/edit-account/edit-country/edit-country.component';
import { EditNameComponent } from './identityManagement/user/user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './identityManagement/user/user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './identityManagement/user/user-account/edit-account/edit-username/edit-username.component';
import { UserAccountComponent } from './identityManagement/user/user-account/user-account.component';
import { UserComponent } from './identityManagement/user/user.component';
import { UserService } from './identityManagement/user/user.service';


@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    UserComponent,
    UserAccountComponent,
    LoginComponent,
    RegisterComponent,
    ContactComponent,
    DetailsAccountComponent,
    EditCountryComponent,
    EditNameComponent,
    EditPhoneComponent,
    EditUsernameComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
