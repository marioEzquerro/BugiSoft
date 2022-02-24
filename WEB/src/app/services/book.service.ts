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

  postBookData(body : any) : Book {
    let bodyData =new Book();
    bodyData.isbn=body.bookISBN;
    bodyData.name=body.bookName;
    bodyData.pages=body.bookPages;
    bodyData.publishDate= new Date();


    let result =new Book();
    this.http.post<Book>(environment.API_URL + 'books',bodyData)
    .subscribe(
      (response) => {                           
        console.log('response received')
        result = response;
      },
      (error) => {                            
        console.error('error caught in component')
      }
    )
    return result;
  }
}
