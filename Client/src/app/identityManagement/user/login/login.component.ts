import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";
import { UserService } from "../user.service";

@Component({
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    formModel={
        Email: '',
        Password: ''
      }

    constructor(private userService: UserService, private router: Router) {

    }

    ngOnInit(): void {
        if(localStorage.getItem('token') != null )
        this.router.navigateByUrl('/user');
    }

    login(form: NgForm) {
        this.userService.login(form.value).subscribe((res:any) => {
            localStorage.setItem('token', res.token)
            this.router.navigateByUrl('/user');
            localStorage.setItem('loggedIn', 'true');
            this.userService.isLoggedIn$.next(true);
        },
        err=>{
            if(err.status == 400)
            {
              localStorage.setItem('loggedIn','false');
            }
            else
              console.log(err);
          }
        )
    }
}