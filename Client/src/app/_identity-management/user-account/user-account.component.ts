import { Component, OnInit } from "@angular/core";
import { UserAccountService } from "./user-account.service";

@Component({
    selector: 'user-account',
    templateUrl: './user-account.component.html',
    styleUrls: ['./user-account.component.css']
})
export class UserAccountComponent implements OnInit {
    constructor(private userService: UserAccountService) {}

    ngOnInit() {
        this.userService.user
    }
}