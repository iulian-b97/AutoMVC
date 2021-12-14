import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './common/contact/contact.component';
import { HomeComponent } from './common/home/home.component';
import { NavBarComponent } from './common/nav/nav-bar.component';
import { AuthenticationInterceptor } from './interceptors/authentication.interceptor';
import { AuthenticationComponent } from './_identity-management/authentication/authentication.component';
import { AuthenticationService } from './_identity-management/authentication/authentication.service';
import { LoginComponent } from './_identity-management/authentication/login/login.component';
import { RefreshTokenService } from './_identity-management/authentication/refresh-token.service';
import { RegisterComponent } from './_identity-management/authentication/register/register.component';
import { EditCountryComponent } from './_identity-management/user-account/edit-account/edit-country/edit-country.component';
import { EditNameComponent } from './_identity-management/user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './_identity-management/user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './_identity-management/user-account/edit-account/edit-username/edit-username.component';
import { UserAccountComponent } from './_identity-management/user-account/user-account.component';
import { DetailsAccountComponent } from './_identity-management/user-account/view-account/view-account.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    AuthenticationComponent,
    UserAccountComponent,
    LoginComponent,
    RegisterComponent,
    ContactComponent,
    HomeComponent,
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
    AuthenticationService,
    RefreshTokenService,
    { provide: HTTP_INTERCEPTORS, useClass: AuthenticationInterceptor, multi: true } 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
