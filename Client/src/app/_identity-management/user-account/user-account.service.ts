import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { IdentityService } from "../identity.service";
import { User } from "./user.model";
import { Observable } from "rxjs";


@Injectable({
    providedIn: 'root'
})
export class UserAccountService extends IdentityService {
    user: User = new User()

    constructor(protected fb: FormBuilder, protected http: HttpClient) {
        super(http)

        if(localStorage.getItem('token') != null)
        { 
            this.user.userName = Object.values(JSON.parse(localStorage.getItem('user')))[0]?.toString()
            this.user.email = Object.values(JSON.parse(localStorage.getItem('user')))[1]?.toString()
            this.user.firstName = Object.values(JSON.parse(localStorage.getItem('user')))[4]?.toString()  
            this.user.country = Object.values(JSON.parse(localStorage.getItem('user')))[3]?.toString()
            this.user.phoneNumber = Object.values(JSON.parse(localStorage.getItem('user')))[2]?.toString()
            this.user.lastName = Object.values(JSON.parse(localStorage.getItem('user')))[5]?.toString()          
        }   
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
        return this.http.get(this.BaseURI + '/userProfile/userId')
    }

    getUserAccount(): Observable<User> {
        return this.http.get<User>(this.BaseURI + '/userProfile/userAccount')
    }
    
    patchUserAccount(val_path:string, val_value:string) {
        const body = [{
            op: "replace",
            path: val_path,
            value: val_value
        }]

        if(val_path == '/Country') {
            this.user.country = val_value
        }

        if(val_path == '/UserName') {
            this.user.userName = val_value
        }

        if(val_path == '/PhoneNumber') {
            this.user.phoneNumber = val_value
        }

        if(val_path == '/FirstName') {
            this.user.firstName = val_value
        }
        if(val_path == '/LastName') {
            this.user.lastName = val_value
        }

        localStorage.setItem("user", JSON.stringify(this.user))

        return this.http.patch(this.BaseURI + '/userProfile/updateUserAccount', body)
    }

    getUserDetail(userId: string) {
        const params = new HttpParams()
            .set('userId', userId)

        return this.http.get(this.BaseURI + '/userProfile/userDetail', {params})
    }
}

