import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './identityManagement/user/login/login.component';
import { RegisterComponent } from './identityManagement/user/register/register.component';
import { UserComponent } from './identityManagement/user/user.component';

const routes: Routes = [
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
