import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { BehaviorSubject, Observable, throwError, pipe } from 'rxjs';
import { switchMap, filter, catchError, take } from 'rxjs/operators';
import { RefreshTokenService } from "../_identity-management/authentication/refresh-token.service";

@Injectable()
export class AuthenticationInterceptor implements HttpInterceptor {
    private isRefreshing = false;
    private refreshTokenSubject: BehaviorSubject<any> = new BehaviorSubject<any>(null);

    constructor(private tokenService: RefreshTokenService) {}

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let authReq = req 
        const token = this.tokenService.getToken()
        if(token != null) {
            authReq = this.addTokenHeader(req, token)
        }

        return next.handle(authReq).pipe(catchError(error => {
            if(error instanceof HttpErrorResponse && error.status === 401) {
                return this.handle401Error(authReq, next)
            }
            return throwError(error)
        }))
    }

    private addTokenHeader(request: HttpRequest<any>, token: string) {
        return request.clone({ headers: request.headers.set('Authorization', 'Bearer ' + token) })
    }

    private handle401Error(request: HttpRequest<any>, next: HttpHandler) {
        if(!this.isRefreshing) {
          this.isRefreshing = true;
          this.refreshTokenSubject.next(null);
    
          const token = this.tokenService.getRefreshToken();
    
          if(token) {
            return this.tokenService.getRefreshTokensRequest().pipe(
              switchMap((token: any) => {
                this.isRefreshing = false;
                this.tokenService.updateToken(token.token);
                this.tokenService.updateRefreshToken(token.refreshToken);
                this.refreshTokenSubject.next(token.token);   
                return next.handle(this.addTokenHeader(request, token.token)); 
              }),
              catchError((err) => {
                this.isRefreshing = false;
                this.tokenService.signOut();
                return throwError(err);
              })
            );
          } else {
            this.isRefreshing = false;
          }
        }
        return this.refreshTokenSubject.pipe(
          filter(token => token !== null),
          take(1),
          switchMap((token) => next.handle(this.addTokenHeader(request, token)))
        );
    }
}


