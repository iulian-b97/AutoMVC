import { Component, OnInit } from "@angular/core";
import { UserAccount } from "../../user-account.model";
import { UserAccountService } from "../../user-account.service";

@Component({
    templateUrl: './edit-phone.component.html',
    styleUrls: ['./edit-phone.component.css']
})
export class EditPhoneComponent implements OnInit {
    user: UserAccount

    constructor(private userService: UserAccountService) {
  
    }
  
    ngOnInit() {
      this.userService.getUserAccount().subscribe((res: any) => {
        this.user = res
        console.log(this.user)
      })
    }
}