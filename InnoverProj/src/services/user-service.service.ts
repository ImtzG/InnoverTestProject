import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError } from 'rxjs';
import { User } from 'src/dto/user';


@Injectable({
  providedIn: 'root'
})
export class UserServiceService {
  public apiUrl = "http://localhost:56600/api";
  public headers =  new HttpHeaders().set('Content-type','application/json');

  constructor(private http: HttpClient) { }

  getStudentList(): Observable<User[]>{
    debugger
    const endpoint_url = this.apiUrl +'/student/data';
    return this.http.post<User[]>(endpoint_url, {headers: this.headers});
  }
}
