import { Component, OnInit } from "@angular/core";
import { UserAccount } from "../../user-account.model";
import { UserAccountService } from "../../user-account.service";

@Component({
    templateUrl: './edit-name.component.html',
    styleUrls: ['./edit-name.component.css']
})
export class EditNameComponent implements OnInit {
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