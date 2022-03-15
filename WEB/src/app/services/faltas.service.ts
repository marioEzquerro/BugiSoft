import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Faltas } from '../models/faltas.model';

@Injectable()
export class FaltasService {
  constructor(private http: HttpClient) {}
  getBookData() : Observable<Faltas[]> {
    return this.http.get<Faltas[]>(environment.API_URL + 'faltas');
  }
}
