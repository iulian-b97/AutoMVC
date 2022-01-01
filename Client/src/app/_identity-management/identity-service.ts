import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class IdentityService {
    public isLoggedIn$: BehaviorSubject<boolean>

    constructor(protected http: HttpClient) {
        const isLoggedIn = localStorage.getItem('loggedIn') === 'true'
        this.isLoggedIn$ = new BehaviorSubject(isLoggedIn)
    }

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }

    readonly BaseURI = 'http://localhost:38447/api';
}