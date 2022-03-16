import { Component } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  ValidationErrors,
  ValidatorFn,
} from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { NoticiaService } from 'src/app/services/noicia.service';

@Component({
  selector: 'app-form-noticia',
  templateUrl: './form-noticia.component.html',
  styleUrls: ['./form-noticia.component.css']
})
export class FormNoticiaComponent {

  noticiaForm = this.fb.group({
    nom: ['', Validators.required],
    desc_c: [''],
    desc_l: ['', Validators.required],
    img: ['', Validators.required],
    fecha: new Date(),
  });

  get aliases() {
    return this.noticiaForm.get('aliases') as FormArray;
  }

  constructor(private fb: FormBuilder, private _noticiaService: NoticiaService) {}

  onSubmit() {
    this._noticiaService.postNoticiaData(this.noticiaForm.value);
    window.location.reload();
  }

}
