import { ChangeDetectionStrategy, Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";
import { BehaviorSubject } from "rxjs";
import { NavBarComponent } from "src/app/common/nav/nav-bar.component";
import { UserAccountService } from "../../user-account/user-account.service";
import { AuthenticationService } from "../authentication.service";

@Component({
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class LoginComponent implements OnInit {
    formModel={ 
        Email: '',
        Password: ''
      }

    constructor(private authService: AuthenticationService, public userService: UserAccountService, private router: Router) {
          
    }

    ngOnInit(): void {
        if(localStorage.getItem('token') != null )
        {
            this.router.navigateByUrl('/home');
        }
        
    }

    login(form: NgForm) {
        this.authService.login(form.value).subscribe((res:any) => {
            localStorage.setItem('token', res.token)
            localStorage.setItem('refreshToken', res.refreshToken)
            this.router.navigateByUrl('/home');
            localStorage.setItem('loggedIn', 'true');
            this.authService.isLoggedIn$.next(true);       
        },
        err=>{
            if(err.status == 400)
            {
              localStorage.setItem('loggedIn','false');
            }
            else
              console.log(err);
          }
        )
    }
}