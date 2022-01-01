import { Component, OnInit } from '@angular/core';
import { UserAccountService } from '../user-account.service';

@Component({
  templateUrl: './view-account.component.html',
  styleUrls: ['./view-account.component.css']
})
export class DetailsAccountComponent {
    constructor(public userService: UserAccountService) {}
}
