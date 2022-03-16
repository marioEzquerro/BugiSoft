import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NoticiaService } from 'src/app/services/noticia.service';
import { Noticia } from 'src/app/models/noticia.model';

@Component({
  selector: 'app-item-noticia-component',
  templateUrl: './item-noticia-component.component.html',
  styleUrls: ['./item-noticia-component.component.css'],
})
export class ItemNoticiaComponentComponent implements OnInit {
  noticias: Noticia | null;
  idNoticia: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private _noticiaService: NoticiaService
  ) {
    this.noticias = null;
    this.idNoticia = 0;
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((parameters: any) => {
      this.idNoticia = parameters.get('idNoticia');

      this._noticiaService
        .getNoticiaById(this.idNoticia)
        .subscribe((apiNoticias) => (this.noticias = apiNoticias));
    });
  }
}
