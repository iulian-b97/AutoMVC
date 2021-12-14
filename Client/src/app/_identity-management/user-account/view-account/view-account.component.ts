import { Component, OnInit } from '@angular/core';
import { UserAccount } from '../user-account.model';
import { UserAccountService } from '../user-account.service';

@Component({
  templateUrl: './view-account.component.html',
  styleUrls: ['./view-account.component.css']
})
export class DetailsAccountComponent implements OnInit {
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
