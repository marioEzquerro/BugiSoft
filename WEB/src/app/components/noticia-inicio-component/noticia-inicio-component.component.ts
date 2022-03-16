import { Component, OnInit } from '@angular/core';
import { Noticia } from 'src/app/models/noticia.model';
import { NoticiaService } from 'src/app/services/noticia.service';

@Component({
  selector: 'app-noticia-inicio-component',
  templateUrl: './noticia-inicio-component.component.html',
  styleUrls: ['./noticia-inicio-component.component.css'],
})
export class NoticiaInicioComponentComponent implements OnInit {
  noticia: Noticia | null;

  constructor(private _noticiaService: NoticiaService) {
    this.noticia = null;
  }

  ngOnInit(): void {
    this._noticiaService
      .getLastNoticiaData()
      .subscribe((x) => (this.noticia = x));
    console;
  }
}
