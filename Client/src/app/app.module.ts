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
    ContactComponent
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
