import { Component, Input, OnInit } from "@angular/core";
import { UserService } from "../user.service";

@Component({
    selector: 'user-account',
    templateUrl: './user-account.component.html',
    styleUrls: ['./user-account.component.css']
})
export class UserAccountComponent implements OnInit {
    user: any

    constructor(private userService: UserService) {

    }

    ngOnInit() {
      console.log(".....");
    }
}