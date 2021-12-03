import { ThrowStmt } from "@angular/compiler";
import { Component, OnInit } from "@angular/core"; 
import { UserService } from "../../../user.service";
import { UserAccount } from "../../user-account.model";

@Component({
    templateUrl: './edit-country.component.html',
    styleUrls: ['./edit-country.component.css']
})
export class EditCountryComponent implements OnInit {
    user: UserAccount

    constructor(private userService: UserService) {
      
    }

    ngOnInit() {
      this.userService.getUserAccount().subscribe((res: any) => {
        this.user = res
        console.log(this.user)
      })   
    }

    onSubmit(val_path:string, val_value:string) {
      this.userService.patchUserAccount(val_path, val_value).subscribe(
        (data: any) => {
          console.log(data)
        }
      ) 
    }
}