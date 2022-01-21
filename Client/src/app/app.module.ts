import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { IdentitytModule } from './_identity-management/identity.module';
import { AnnouncementModule } from './_announcement-management/announcement.module';
import { SharedModule } from './common/shared.module';

import { AuthenticationService } from './_identity-management/authentication/authentication.service';
import { RefreshTokenService } from './_identity-management/authentication/refresh-token.service';
import { AuthenticationInterceptor } from './interceptors/authentication.interceptor';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    IdentitytModule,
    AnnouncementModule,
    SharedModule
  ],
  providers: [
    AuthenticationService,
    RefreshTokenService,
    { provide: HTTP_INTERCEPTORS, useClass: AuthenticationInterceptor, multi: true } 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
