import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { BehaviorSubject } from "rxjs";


@Injectable({
    providedIn: 'root'
})
export class UserService{
    public isLoggedIn$: BehaviorSubject<boolean>; 

    constructor(private fb: FormBuilder, private http: HttpClient) {
        const isLoggedIn = localStorage.getItem('loggedIn') === 'true'
        this.isLoggedIn$ = new BehaviorSubject(isLoggedIn)
    }

    readonly BaseURI = 'http://localhost:38447/api';

    formModel = this.fb.group({
        UserName :['',Validators.required],
        Email :['',Validators.email],
        Passwords : this.fb.group({
          Password :['',[Validators.required,Validators.minLength(4)]],
          ConfirmPassword :['',Validators.required]
        },{validator : this.comparePasswords}),
        PhoneNumber:['',Validators.required],
        Country:['',Validators.required]
      });

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }

    comparePasswords(fb:FormGroup) {
        let confirmPswrdCtrl = fb.get('ConfirmPassword');

        if(confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors)
        {
        if(fb.get('Password').value != confirmPswrdCtrl?.value)
        confirmPswrdCtrl.setErrors({passwordMismatch: true});
        else
        confirmPswrdCtrl.setErrors(null);
        }
    }

    register() {
        var body = {
            UserName: this.formModel.value.UserName,
            Email: this.formModel.value.Email,
            Password: this.formModel.value.Passwords.Password,
            PhoneNumber: this.formModel.value.PhoneNumber,
            Country: this.formModel.value.Country
        };

        return this.http.post(this.BaseURI + '/authentication/register', body);
    }

    login(formData: any) {
        return this.http.post(this.BaseURI + '/authentication/login', formData);
    }
}