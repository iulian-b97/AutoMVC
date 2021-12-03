import { Component, OnInit  } from "@angular/core";
import { UserService } from "../../../user.service";
import { UserAccount } from "../../user-account.model";

@Component({
    selector: 'app-edit-username',
    templateUrl: './edit-username.component.html',
    styleUrls: ['./edit-username.component.css']
})
export class EditUsernameComponent implements OnInit {
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