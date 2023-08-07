import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { environment } from 'src/environment/environment';
import { SchedulePlayDto } from '../model/dtos/schedule_play_dto';

const baseUrl = `${environment.apiUrl}/SchedulePlay`;

@Injectable({
  providedIn: 'root'
})
export class ScheduleService {
  constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<SchedulePlayDto[]>(`${baseUrl}/GetAll`);
    }

    getById(id: string) {
        return this.http.get<SchedulePlayDto>(`${baseUrl}/${id}`);
    }

    create(params: any) {
        return this.http.post(`${baseUrl}/Add`, params);
    }

    update(id: string, params: any) {
        return this.http.put(`${baseUrl}/${id}`, params);
    }

    delete(id: string) {
        return this.http.delete(`${baseUrl}/${id}`);
    }
}



  /*
  apiurl = 'api/users';                 // Our created Data can be accessed here at api/users
  headers = new HttpHeaders().set('Content-Type', 'application/json').set('Accept', 'application/json');
  httpOptions = {
    headers: this.headers
  };
  */

 // constructor(private http: HttpClient) { }    
  //Injecting HTTP service to communicate with the data


  /*
  private handleError(error: any) {
    console.error(error);                                       //Created a function to handle and log errors, in case
    return throwError(error);
  }
  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.apiurl).pipe(
      tap(data => console.log(data)),
      catchError(this.handleError)
    );
  }
  getUser(id: number): Observable<UserFetch> {
    const url = `${this.apiurl}/${id}`;
    return this.http.get<UserFetch>(url).pipe(
    catchError(this.handleError)
    );
    }

    addUser (user: UserFetch): Observable<UserFetch> {
      user.id=null;
      return this.http.post<UserFetch>(this.apiurl, user, this.httpOptions).pipe(
        tap(data => console.log(data)),
        catchError(this.handleError)
      );
  }

  deleteUser(id: number): Observable<UserFetch> {
    const url = `${this.apiurl}/${id}`;
    return this.http.delete<UserFetch>(url, this.httpOptions).pipe(
      catchError(this.handleError)
    );
  }

  updateUser(user: UserFetch): Observable<UserFetch>{
    const url = `${this.apiurl}/${user.id}`;
    return this.http.put<UserFetch>(this.apiurl, user, this.httpOptions).pipe(
      map(() => user),
      catchError(this.handleError)
    );
  }

  */

