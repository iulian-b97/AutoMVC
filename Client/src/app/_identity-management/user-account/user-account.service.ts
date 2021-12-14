import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { IdentityService } from "../identity-service";
import { User } from "./user.model";
import { Observable } from "rxjs";


@Injectable({
    providedIn: 'root'
})
export class UserAccountService extends IdentityService {
    constructor(protected fb: FormBuilder, protected http: HttpClient) {
        super(http)
    }

    userForm = this.fb.group({
        UserName :['', Validators.required],
        Email :['', Validators.required],
        FirstName :[''],
        LastName :[''],
        PhoneNumber :['', Validators.required],
        Country :['', Validators.required]
    })

    getUserId() {
        var tokenHeader = new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})

        return this.http.get(this.BaseURI + '/userProfile/userId', {headers: tokenHeader})
    }

    getUserAccount(): Observable<User> {
        //var tokenHeader = new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})

        return this.http.get<User>(this.BaseURI + '/userProfile/userAccount')
    }
    /*userAccount$ = this.http.get<User[]>(this.BaseURI + '/userProfile/userName', {headers: new HttpHeaders({'Authorization':'Bearer '+ localStorage.getItem('token')})})
                        .pipe(
                            tap(data => console.log(JSON.stringify(data)))
                        )*/

    
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
}

