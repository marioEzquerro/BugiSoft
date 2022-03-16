import { Component, OnInit } from '@angular/core';
import { Noticia } from 'src/app/models/noticia.model';
import { NoticiaService } from 'src/app/services/noticia.service';

@Component({
  selector: 'app-noticias-page',
  templateUrl: './noticias-page.component.html',
  styleUrls: ['./noticias-page.component.css'],
})
export class NoticiasPageComponent implements OnInit {
  noticias: Noticia[] | null;

  constructor(private _noticiaService: NoticiaService) {
    this.noticias = null;
  }

  ngOnInit(): void {
    this._noticiaService.getNoticiaData().subscribe((x) => (this.noticias = x));
  }
}
