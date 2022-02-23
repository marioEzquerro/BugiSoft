import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { PRODUCTOS } from 'src/app/utils/productConstants';

@Component({
  selector: 'app-list-products',
  templateUrl: './list-products.component.html',
  styleUrls: ['./list-products.component.css'],
})
export class ListProductsComponent implements OnInit {
  @Output() likeEvent = new EventEmitter<string>();
  productos: Product[] | null;

  @Input() filter: string | null;

  constructor() {
    this.productos = null;
    this.filter = null;
  }

  like() {
    this.likeEvent.emit();
  }
  ngOnInit(): void {
    this.productos = PRODUCTOS;
  }
}
