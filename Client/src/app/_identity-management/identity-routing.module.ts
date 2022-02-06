import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../auth/auth.guard';

import { AuthenticationComponent } from './authentication/authentication.component';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { EditCountryComponent } from './user-account/edit-account/edit-country/edit-country.component';
import { EditNameComponent } from './user-account/edit-account/edit-name/edit-name.component';
import { EditPhoneComponent } from './user-account/edit-account/edit-phone/edit-phone.component';
import { EditUsernameComponent } from './user-account/edit-account/edit-username/edit-username.component';
import { UserAccountComponent } from './user-account/user-account.component';
import { DetailsAccountComponent } from './user-account/view-account/view-account.component';


const routes: Routes = [
    {
        path: 'user', component: AuthenticationComponent, 
        children: [
            { path: 'login', component: LoginComponent }, 
            { path: 'register', component: RegisterComponent }
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
  export class IdentityRoutingModule { }