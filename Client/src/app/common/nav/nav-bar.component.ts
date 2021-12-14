import { ChangeDetectionStrategy, Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject } from "rxjs";
import { AuthenticationService } from "src/app/_identity-management/authentication/authentication.service";
import { UserAccountService } from "src/app/_identity-management/user-account/user-account.service";
import { User } from "src/app/_identity-management/user-account/user.model";

@Component({
    selector: 'nav-bar',
    templateUrl: './nav-bar.component.html',
    styleUrls: ['./nav-bar.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class NavBarComponent implements OnInit {
    show:boolean = true
    user: User
    

    constructor(public authService: AuthenticationService, public userService: UserAccountService, private router: Router) {
    }

    ngOnInit() {
        this.authService.email$ = new BehaviorSubject('My account')  
    }

    isLogged(): boolean {
        return this.authService.isLogged()
    } 

    onShow() {
        if(!this.show)
        {
            this.show = true
        }
        else
        {
            this.show = false
        }
    }

    onLogout() {
        this.authService.logout();

        return this.router.navigate(['/home']);
    }
}