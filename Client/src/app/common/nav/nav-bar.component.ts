import { Component } from "@angular/core";
import { Router } from "@angular/router";
import { UserService } from "src/app/identityManagement/user/user.service";

@Component({
    selector: 'nav-bar',
    templateUrl: './nav-bar.component.html',
    styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent{
    show:boolean = true

    constructor(private userService: UserService, private router: Router) {
        
    }

    isLogged(): boolean {
        return this.userService.isLogged();
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
        this.userService.logout();

        return this.router.navigate(['/user/login']);
    }
}