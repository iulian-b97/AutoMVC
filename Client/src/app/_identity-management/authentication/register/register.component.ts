import { Component } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { AuthenticationService } from "../authentication.service";

@Component({
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent {
    constructor(private authService: AuthenticationService, 
                private fb: FormBuilder, 
                private router: Router) {}

    registerForm = this.fb.group({
        UserName :['',Validators.required],
        Email :['',Validators.email],
        Passwords : this.fb.group({
          Password :['',[Validators.required,Validators.minLength(4)]],
          ConfirmPassword :['',Validators.required]
        },{validator : this.authService.comparePasswords}),
        PhoneNumber:['',Validators.required],
        Country:['',Validators.required]
      });

    register() {
        this.authService.register(this.registerForm).subscribe(() => {
            this.registerForm.reset()
            this.router.navigateByUrl('/user/login');
        })
    }
}