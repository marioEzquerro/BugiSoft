import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Book } from '../models/book.model';

@Injectable()
export class BookService {
  constructor(private http: HttpClient) {}
  getBookData() : Observable<Book[]> {
    return this.http.get<Book[]>(environment.API_URL + 'books');
  }
}
