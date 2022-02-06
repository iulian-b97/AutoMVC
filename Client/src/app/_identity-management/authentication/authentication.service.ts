import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
import { BehaviorSubject } from "rxjs";
import { IdentityService } from "../identity.service";


@Injectable({
    providedIn: 'root'
})
export class AuthenticationService extends IdentityService {
    email$: BehaviorSubject<string> 

    constructor(protected fb: FormBuilder, protected http: HttpClient) {
        super(http)
    }

    comparePasswords(registerForm: FormGroup) {
        let confirmPswrdCtrl = registerForm.get('ConfirmPassword');

        if(confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors)
        {
        if(registerForm.get('Password').value != confirmPswrdCtrl?.value)
        confirmPswrdCtrl.setErrors({passwordMismatch: true});
        else
        confirmPswrdCtrl.setErrors(null);
        }
    }

    register(registerForm: FormGroup) {
        var body = {
            UserName: registerForm.value.UserName,
            Email: registerForm.value.Email,
            Password: registerForm.value.Passwords.Password,
            PhoneNumber: registerForm.value.PhoneNumber,
            Country: registerForm.value.Country
        };

        return this.http.post(this.BaseURI + '/authentication/register', body);
    }

    login(formData: any) {
        return this.http.post(this.BaseURI + '/authentication/login', formData);
    }

    logout() {
        localStorage.setItem('loggedIn', 'false');
        this.isLoggedIn$.next(false);

        localStorage.removeItem('token');
    }

    isLogged(): boolean {
        return this.isLoggedIn$.value
    } 
}