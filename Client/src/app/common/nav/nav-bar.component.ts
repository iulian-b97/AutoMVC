import { ChangeDetectionStrategy, Component } from "@angular/core";
import { Router } from "@angular/router";
import { AuthenticationService } from "src/app/_identity-management/authentication/authentication.service";
import { UserAccountService } from "src/app/_identity-management/user-account/user-account.service";

@Component({
    selector: 'nav-bar',
    templateUrl: './nav-bar.component.html',
    styleUrls: ['./nav-bar.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class NavBarComponent {
    show:boolean = true

    constructor(public authService: AuthenticationService, 
                public userService: UserAccountService, 
                private router: Router) {}

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