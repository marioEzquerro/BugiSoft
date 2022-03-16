import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Book } from 'src/app/models/book.model';
import { BookService } from 'src/app/services/book.service';

@Component({
  selector: 'app-list-books',
  templateUrl: './list-books.component.html',
  styleUrls: ['./list-books.component.css'],
})
export class ListBooksComponent implements OnInit {
  @Output() likeEvent = new EventEmitter<string>();
  books: Book[] | null;

  @Input() filter: string | null;

  constructor(private _bookService: BookService) {
    this.books = null;
    this.filter = null;

  }

  like() {
    this.likeEvent.emit();
  }
  ngOnInit(): void {
     this._bookService.getBookData().subscribe(apiBooks => this.books=apiBooks);
  }
}
