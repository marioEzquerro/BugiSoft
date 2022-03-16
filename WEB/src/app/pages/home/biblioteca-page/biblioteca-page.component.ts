import { Component, OnInit } from '@angular/core';
import { Juego } from 'src/app/models/juego.model';
import { JuegoService } from 'src/app/services/juego.service';

@Component({
  selector: 'app-biblioteca-page',
  templateUrl: './biblioteca-page.component.html',
  styleUrls: ['./biblioteca-page.component.css']
})
export class BibliotecaPageComponent implements OnInit {
  juegos: Juego[] | null;

  constructor(private _juegoService: JuegoService) { 
    this.juegos = null;
  }

  ngOnInit(): void {
    this._juegoService.getJuegoData().subscribe(x => this.juegos = x);
  }

}
