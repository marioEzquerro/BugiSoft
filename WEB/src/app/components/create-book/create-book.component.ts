import { Component } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  ValidationErrors,
  ValidatorFn,
} from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { Book } from 'src/app/models/book.model';
import { BookService } from 'src/app/services/book.service';

@Component({
  selector: 'app-create-book',
  templateUrl: './create-book.component.html',
  styleUrls: ['./create-book.component.css']
})
export class CreateBookComponent {



  constructor(private fb: FormBuilder,private _bookService: BookService) {}


  bookForm = this.fb.group({
    bookName: ['', Validators.required],
    bookISBN: ['',Validators.required],
    bookPages: ['',Validators.required],
  });


  ngOnInit(): void {
  }

  onSubmit() {
    this._bookService.postBookData(this.bookForm.value);
  }

}
