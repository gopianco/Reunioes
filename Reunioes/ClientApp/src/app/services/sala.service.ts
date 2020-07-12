import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Sala } from '../model/sala';
import { StaticClassProvider } from '@angular/core/src/di/provider';

@Injectable({
  providedIn: 'root'
})
export class SalaService implements OnInit{

  private _baseURL: string;
  private salas: Sala[];

  get headers():HttpHeaders{
    return new HttpHeaders().set('content-type', 'application/json');
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 

    this._baseURL = baseUrl;
  }

  ngOnInit(): void {
    this.salas = [];
  }

  public cadastrar(sala: Sala): Observable<Sala> {

    return this.http.post<Sala>(this._baseURL + 'api/sala', JSON.stringify(sala), { headers: this.headers });
  }

  public obterTodos(): Observable<Sala[]> {
    return this.http.get<Sala[]>(this._baseURL + 'api/sala');
  }

  public deletar(sala: Sala): Observable<Sala[]> {
    return this.http.post<Sala[]>(this._baseURL + 'api/sala/deletar', JSON.stringify(sala), { headers: this.headers });
  }
}
