import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError, flatMap } from 'rxjs/operators';

import { Aparelho } from './aparelho.model';

@Injectable({
  providedIn: 'root'
})
export class AparelhoService {

  private apiPath: string = 'https://localhost:44386/';

  constructor(private http: HttpClient) { }

  /* listar tudo */
  getAll(): Observable<Aparelho[]> {
    return this.http.get(this.apiPath + 'aparelho').pipe(
      map(this.jsonDataToCategories.bind(this)),
      catchError(this.handleError)
    );
  }

  delete(id: string): Observable<any> {
    const url = `${this.apiPath + 'aparelho'}/${id}`;
    return this.http.delete(url).pipe(
      catchError(this.handleError),
      map(() => null)
    );
  }

  /* Métodos privados */
  private jsonDataToCategories(jsonData: any[]): Aparelho[] {
    const aparelhos: Aparelho[] = [];
    jsonData.forEach(element => aparelhos.push(element as Aparelho));
    return aparelhos;
  }

  private handleError(error: any): Observable<any> {
    console.log('ERRO NA REQUISIÇÃO => ', error);
    return throwError(error);
  }
}
