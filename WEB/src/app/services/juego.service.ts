import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Juego } from '../models/juego.model';

@Injectable()
export class JuegoService {
  constructor(private http: HttpClient) {}
  getJuegoData(): Observable<Juego[]> {
    return this.http.get<Juego[]>(environment.API_URL + 'juegos');
  }

  getJuegoById(id: any): Observable<Juego> {
    return this.http.get<Juego>(environment.API_URL + 'juegos/' + id);
  }

  postJuegoData(body: any): Juego {
    let bodyData = new Juego();
    bodyData.nombre = body.nom;
    bodyData.descripcion = body.desc;
    bodyData.fecha_lanzamiento = new Date(body.fecha);
    bodyData.genero = body.genero;
    bodyData.plataforma = body.plat;
    bodyData.imagen = body.img;

    let result = new Juego();
    this.http.post<Juego>(environment.API_URL + 'juegos', bodyData).subscribe(
      (response) => {
        console.log('response received');
        result = response;
      },
      (error) => {
        console.error('error caught in component');
      }
    );
    return result;
  }
}
