import { Component } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  ValidationErrors,
  ValidatorFn,
} from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { JuegoService } from 'src/app/services/juego.service';

@Component({
  selector: 'app-form-juego',
  templateUrl: './form-juego.component.html',
  styleUrls: ['./form-juego.component.css']
})
export class FormJuegoComponent {

  juegoForm = this.fb.group({
    nom: ['', Validators.required],
    desc: ['', Validators.required],
    fecha: ['', Validators.required],
    genero: ['', Validators.required],
    plat: ['', Validators.required],
    img: ['', Validators.required]
  });

  get aliases() {
    return this.juegoForm.get('aliases') as FormArray;
  }

  constructor(private fb: FormBuilder, private _juegoService: JuegoService) {}

  onSubmit() {
    this._juegoService.postJuegoData(this.juegoForm.value);

  }

}
