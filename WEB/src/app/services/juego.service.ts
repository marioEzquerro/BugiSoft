import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Juego } from '../models/juego.model'; 

@Injectable()
export class JuegoService {
  constructor(private http: HttpClient) {}
  getJuegoData() : Observable<Juego[]> {
    return this.http.get<Juego[]>(environment.API_URL + 'juegos');
  }
}
