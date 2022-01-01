import { Component } from "@angular/core";
import { UserAccountService } from "../../user-account.service";

@Component({
    templateUrl: './edit-phone.component.html',
    styleUrls: ['./edit-phone.component.css']
})
export class EditPhoneComponent {

    constructor(public userService: UserAccountService) {}

    onSubmit(val_path:string, val_value:string) {
        this.userService.patchUserAccount(val_path, val_value).subscribe(
          (data: any) => {
            console.log(data)
          }
        ) 
    }
}