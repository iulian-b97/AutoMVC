import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
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

    logout() {
        localStorage.setItem('loggedIn', 'false');
        this.isLoggedIn$.next(false);

        localStorage.removeItem('token');
    }

    getUserId() {
        var tokenHeader = new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})

        return this.http.get(this.BaseURI + '/userProfile/userId', {headers: tokenHeader})
    }

    getUserAccount() {
        var tokenHeader = new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})

        return this.http.get(this.BaseURI + '/userProfile/userAccount', {headers: tokenHeader})
    }
    
    patchUserAccount(val_path:string, val_value:string) {
        const body = [{
            op: "replace",
            path: val_path,
            value: val_value
        }]

        var tokenHeader = new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})

        return this.http.patch(this.BaseURI + '/userProfile/updateUserAccount', body, {headers: tokenHeader})
    }

    getUserDetail(userId: string) {
        const params = new HttpParams()
            .set('userId', userId)

        return this.http.get(this.BaseURI + '/userProfile/userDetail', {params})
    }

    isLogged(): boolean {
    return this.isLoggedIn$.value;
  }
}