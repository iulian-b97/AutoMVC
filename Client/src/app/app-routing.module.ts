import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './identityManagement/auth/auth.guard';
import { LoginComponent } from './identityManagement/user/login/login.component';
import { RegisterComponent } from './identityManagement/user/register/register.component';
import { DetailsAccountComponent } from './identityManagement/user/user-account/edit-account/details-account/details-account.component';
import { EditCountryComponent } from './identityManagement/user/user-account/edit-account/edit-country/edit-country.component';
import { EditNameComponent } from './identityManagement/user/user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './identityManagement/user/user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './identityManagement/user/user-account/edit-account/edit-username/edit-username.component';
import { UserAccountComponent } from './identityManagement/user/user-account/user-account.component';
import { UserComponent } from './identityManagement/user/user.component';

const routes: Routes = [
  { 
    path: 'user-account', component: UserAccountComponent, canActivate:[AuthGuard],
    children: [
      { path: 'details-account', component: DetailsAccountComponent },
      { path: 'edit-country', component: EditCountryComponent },
      { path: 'edit-name', component: EditNameComponent },
      { path: 'edit-phone', component: EditPhoneComponent },
      { path: 'edit-username', component: EditUsernameComponent }
    ]
  },
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'login', component:LoginComponent }, 
      { path: 'register', component:RegisterComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
