import { Component, Input } from "@angular/core";
import { UserService } from "../user.service";

@Component({
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent {
    constructor(public userService: UserService) {

    }

    register() {
        this.userService.register().subscribe(() => {
            this.userService.formModel.reset()
        })
    }
}