export class Book {
  id: number;

  isbn: string | null;

  name: string | null;

  pages: number;

  publishDate: Date | null;

  constructor() {
    this.id = 0;
    this.isbn = null;
    this.name = null;
    this.pages = 0;
    this.publishDate=null;
  }
}
