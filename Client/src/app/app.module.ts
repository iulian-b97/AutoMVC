import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './common/contact/contact.component';

import { HomeComponent } from './common/home/home.component';
import { SearchCarComponent } from './common/home/search/search-car/search-car.component';
import { SearchMotorcycleComponent } from './common/home/search/search-motorcycle/search-motorcycle.component';
import { SearchTrailerComponent } from './common/home/search/search-trailer/search-trailer.component';
import { SearchTruckComponent } from './common/home/search/search-truck/search-truck.component';
import { SearchVanComponent } from './common/home/search/search-van/search-van.component';
import { NavBarComponent } from './common/nav/nav-bar.component';
import { AuthenticationInterceptor } from './interceptors/authentication.interceptor';
import { CarAnnouncementComponent } from './_announcement-management/announcement/car-announcement/car-announcement.component';
import { ViewCarAnnouncementComponent } from './_announcement-management/announcement/car-announcement/view-car-announcement/view-car-announcement.component';
import { MotorcycleAnnouncementComponent } from './_announcement-management/announcement/motorcycle-announcement/motorcycle-announcement.component';
import { TrailerAnnouncementComponent } from './_announcement-management/announcement/trailer-announcement/trailer-announcement.component';
import { TruckAnnouncementComponent } from './_announcement-management/announcement/truck-announcement/truck-announcement.component';
import { VanAnnouncementComponent } from './_announcement-management/announcement/van-announcement/van-announcement.component';
import { FilteredCarAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-car-announcements/filtered-car-announcements.component';
import { FilteredMotorcycleAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-motorcycle-announcements/filtered-motorcycle-announcements.component';
import { FilteredTrailerAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-trailer-announcements/filtered-trailer-announcements.component';
import { FilteredTruckAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-truck-announcements/filtered-truck-announcements.component';
import { FilteredVanAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-van-announcements/filtered-van-announcements.component';
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
    EditUsernameComponent,
    SearchCarComponent,
    SearchMotorcycleComponent,
    SearchTruckComponent,
    SearchVanComponent,
    SearchTrailerComponent,
    CarAnnouncementComponent,
    MotorcycleAnnouncementComponent,
    TruckAnnouncementComponent,
    VanAnnouncementComponent,
    TrailerAnnouncementComponent,
    FilteredCarAnnouncementsComponent,
    FilteredMotorcycleAnnouncementsComponent,
    FilteredTruckAnnouncementsComponent,
    FilteredVanAnnouncementsComponent,
    FilteredTrailerAnnouncementsComponent,
    ViewCarAnnouncementComponent
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
