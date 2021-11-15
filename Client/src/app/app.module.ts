import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './common/contact/contact.component';
import { NavBarComponent } from './common/nav/nav-bar.component';
import { LoginComponent } from './identityManagement/user/login/login.component';
import { RegisterComponent } from './identityManagement/user/register/register.component';
import { UserComponent } from './identityManagement/user/user.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    UserComponent,
    LoginComponent,
    RegisterComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
