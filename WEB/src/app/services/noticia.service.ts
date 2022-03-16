import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Noticia } from '../models/noticia.model';

@Injectable()
export class NoticiaService {
  constructor(private http: HttpClient) {}
  getNoticiaData(): Observable<Noticia[]> {
    return this.http.get<Noticia[]>(environment.API_URL + 'noticias');
  }

  getLastNoticiaData(): Observable<Noticia> {
    return this.http.get<Noticia>(environment.API_URL + 'noticias/last');
  }

  postNoticiaData(body: any): Noticia {
    let bodyData = new Noticia();
    bodyData.nombre = body.nom;
    bodyData.descripcion_corta = body.desc_c;
    bodyData.descripcion = body.desc_l;
    bodyData.img = body.img;
    bodyData.fecha = new Date();

    let result = new Noticia();
    this.http
      .post<Noticia>(environment.API_URL + 'noticias', bodyData)
      .subscribe(
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
