import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Reuniao } from '../model/reuniao';

@Injectable({
  providedIn: 'root'
})
export class ReuniaoService implements OnInit{

  private _baseURL: string;
  private reunioes: Reuniao[];

  get headers():HttpHeaders{
    return new HttpHeaders().set('content-type', 'application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 

    this._baseURL = baseUrl;
  }

  ngOnInit(): void {
    this.reunioes = [];
  }

  public cadastrar(reuniao: Reuniao): Observable<Reuniao> {

    return this.http.post<Reuniao>(this._baseURL + 'api/reuniao', JSON.stringify(reuniao), { headers: this.headers });
  }

  
}
