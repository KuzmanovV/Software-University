import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IUser } from './interfaces';
import { StorageService } from './storage.service';
import { tap } from 'rxjs/operators';

export interface CreateUserDto{username: string, email: string, password: string, tel?: string}

@Injectable()
export class UserService {

  currentUser: IUser;

  get isLogged(){
    return !!this.currentUser;
  }
  
  constructor(private storage: StorageService, private httpClient: HttpClient) {
  }

  login$(userData: {email: string, password: string}): Observable<IUser> {
    return this.httpClient
    .post<IUser>(`${environment.apiUrl}/login`, userData, {withCredentials: true})
    .pipe(tap(user => this.currentUser = user))
  }

  GetProfile$(): Observable<IUser>{
    return this.httpClient.get<IUser>(`${environment.apiUrl}/users/profile`, {withCredentials: true})
    .pipe(tap(user => this.currentUser = user))
  }
  
  logout(): void {
  }

  register$(userData: CreateUserDto): Observable<IUser>{
      return this.httpClient.post<IUser>(`${environment.apiUrl}/register`, userData, {withCredentials: true})
    }
}


