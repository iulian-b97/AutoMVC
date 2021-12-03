import { Component, OnInit } from "@angular/core";
import { UserService } from "../../../user.service";
import { UserAccount } from "../../user-account.model";

@Component({
    templateUrl: './edit-phone.component.html',
    styleUrls: ['./edit-phone.component.css']
})
export class EditPhoneComponent implements OnInit {
    user: UserAccount

    constructor(private userService: UserService) {
  
    }
  
    ngOnInit() {
      this.userService.getUserAccount().subscribe((res: any) => {
        this.user = res
        console.log(this.user)
      })
    }
}