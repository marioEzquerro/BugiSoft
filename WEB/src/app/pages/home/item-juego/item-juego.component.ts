import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {AbstractControl,FormBuilder,ValidationErrors,ValidatorFn,} from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { JuegoService } from 'src/app/services/juego.service';
import { Juego } from 'src/app/models/juego.model';

@Component({
  selector: 'app-item-juego',
  templateUrl: './item-juego.component.html',
  styleUrls: ['./item-juego.component.css']
})
export class ItemJuegoComponent implements OnInit {

  juegos: Juego | null;
  idJuego: number;

  constructor(private activatedRoute: ActivatedRoute, private _juegoService: JuegoService) {
    this.juegos = null;
    this.idJuego = 0;
   }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((parameters: any) => {
      this.idJuego = parameters.get('idJuego');

    this._juegoService.getJuegoById(this.idJuego).subscribe(apiJuegos => this.juegos = apiJuegos);
    });
  }

}
