import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './common/home/home.component';
import { AuthGuard } from './auth/auth.guard';
import { LoginComponent } from './_identity-management/authentication/login/login.component';
import { RegisterComponent } from './_identity-management/authentication/register/register.component';
import { EditCountryComponent } from './_identity-management/user-account/edit-account/edit-country/edit-country.component';
import { UserAccountComponent } from './_identity-management/user-account/user-account.component';
import { DetailsAccountComponent } from './_identity-management/user-account/view-account/view-account.component';
import { EditNameComponent } from './_identity-management/user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './_identity-management/user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './_identity-management/user-account/edit-account/edit-username/edit-username.component';
import { AuthenticationComponent } from './_identity-management/authentication/authentication.component';
import { SearchCarComponent } from './common/home/search/search-car/search-car.component';
import { SearchMotorcycleComponent } from './common/home/search/search-motorcycle/search-motorcycle.component';
import { SearchTruckComponent } from './common/home/search/search-truck/search-truck.component';
import { SearchVanComponent } from './common/home/search/search-van/search-van.component';
import { SearchTrailerComponent } from './common/home/search/search-trailer/search-trailer.component';
import { FilteredCarAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-car-announcements/filtered-car-announcements.component';
import { FilteredMotorcycleAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-motorcycle-announcements/filtered-motorcycle-announcements.component';
import { FilteredTruckAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-truck-announcements/filtered-truck-announcements.component';
import { FilteredVanAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-van-announcements/filtered-van-announcements.component';
import { FilteredTrailerAnnouncementsComponent } from './_announcement-management/filtered-announcements/filtered-trailer-announcements/filtered-trailer-announcements.component';
import { ViewCarAnnouncementComponent } from './_announcement-management/announcement/car-announcement/view-car-announcement/view-car-announcement.component';
import { ViewMororcycleAnnouncementComponent } from './_announcement-management/announcement/motorcycle-announcement/view-motorcycle-announcement/view-motorcycle-announcement.component';

const routes: Routes = [
  { path:'', redirectTo:'/home/search-car', pathMatch:'full' },
  { 
    path: 'home', component: HomeComponent, 
    children: [
      { path: 'search-car', component: SearchCarComponent },
      { path: 'search-motorcycle', component: SearchMotorcycleComponent },
      { path: 'search-truck', component: SearchTruckComponent },
      { path: 'search-van', component: SearchVanComponent },
      { path: 'search-trailer', component: SearchTrailerComponent }
    ] 
  },
  { path: 'car-announcements', component: FilteredCarAnnouncementsComponent },
  { path: 'motorcycle-announcements', component: FilteredMotorcycleAnnouncementsComponent },
  { path: 'truck-announcements', component: FilteredTruckAnnouncementsComponent },
  { path: 'van-announcements', component: FilteredVanAnnouncementsComponent },
  { path: 'trailer-announcements', component: FilteredTrailerAnnouncementsComponent },
  { path: 'view-car-announcement', component: ViewCarAnnouncementComponent },
  { path: 'view-motorcycle-announcement', component: ViewMororcycleAnnouncementComponent },
  {
    path: 'user', component: AuthenticationComponent,
    children: [
      { path: 'login', component:LoginComponent }, 
      { path: 'register', component:RegisterComponent }
    ]
  },
  { 
    path: 'user-account', component: UserAccountComponent, canActivate:[AuthGuard],
    children: [
      { path: 'details-account', component: DetailsAccountComponent },
      { path: 'edit-country', component: EditCountryComponent },
      { path: 'edit-name', component: EditNameComponent },
      { path: 'edit-phone', component: EditPhoneComponent },
      { path: 'edit-username', component: EditUsernameComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
