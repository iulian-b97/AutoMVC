import { Component, OnInit } from "@angular/core";
import { UserService } from "../../../user.service";
import { UserAccount } from "../../user-account.model";

@Component({
    templateUrl: './edit-name.component.html',
    styleUrls: ['./edit-name.component.css']
})
export class EditNameComponent implements OnInit {
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