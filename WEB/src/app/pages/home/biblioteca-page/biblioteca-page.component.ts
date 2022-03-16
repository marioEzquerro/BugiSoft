import { Component, OnInit, Input } from '@angular/core';
import { Juego } from 'src/app/models/juego.model';
import { JuegoService } from 'src/app/services/juego.service';

@Component({
  selector: 'app-biblioteca-page',
  templateUrl: './biblioteca-page.component.html',
  styleUrls: ['./biblioteca-page.component.css']
})
export class BibliotecaPageComponent implements OnInit {
  juegos: Juego[] | null;
  @Input() filter: string | null;


  constructor(private _juegoService: JuegoService) {
    this.juegos = null;
    this.filter = null;
  }

  aplicarFiltro(filtro: string) {
    this.filter = filtro;
  }

  reload() {
    window.location.reload();
  }

  ngOnInit(): void {
    this._juegoService.getJuegoData().subscribe(x => this.juegos = x);
  }

}
