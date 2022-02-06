import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { IdentityService } from "../identity.service";
import { RefreshTokenRequest } from "./refresh-token-request.model";

@Injectable()
export class RefreshTokenService extends IdentityService {
    constructor(protected http: HttpClient, private router: Router) {
        super(http)
    }

    getToken() {
        var result = localStorage.getItem("token");
        return result === null ? "" : result.toString();
      }

    getRefreshToken() {
        var result = localStorage.getItem("refreshToken");
        return result === null ? "" : result.toString();
    }

    getRefreshTokenRequest() {
        var request = new RefreshTokenRequest();
        request.token = this.getToken();
        request.refreshToken = this.getRefreshToken();
        return request;
    }

    updateToken(token: string) {
        localStorage.setItem("token", token);
    }
    
    updateRefreshToken(refreshToken: string) {
        localStorage.setItem("refreshToken", refreshToken);
    }

    getRefreshTokensRequest() {
        return this.http.post(this.BaseURI + '/authentication/refreshToken', this.getRefreshTokenRequest())
    }

    signOut() {
        localStorage.clear();
        this.router.navigate(['/home']);
    }
}