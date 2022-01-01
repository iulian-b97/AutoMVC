import { Component } from "@angular/core";
import { UserAccountService } from "../../user-account.service";

@Component({
    selector: 'app-edit-username',
    templateUrl: './edit-username.component.html',
    styleUrls: ['./edit-username.component.css']
})
export class EditUsernameComponent {

    constructor(public userService: UserAccountService) {}

    onSubmit(val_path:string, val_value:string) {
        this.userService.patchUserAccount(val_path, val_value).subscribe(
          (data: any) => {
            console.log(data)
          }
        ) 
    }
}