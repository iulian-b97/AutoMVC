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
