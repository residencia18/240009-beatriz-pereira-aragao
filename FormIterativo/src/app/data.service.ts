import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class DataService {
  dadosApi = [];
  private apiUrl = 'https://restcountries.com/v3.1/all';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  getFirstData(): Observable<any> {
    return this.http.get<any[]>(this.apiUrl).pipe(map(data => data[0]));
  }
}
