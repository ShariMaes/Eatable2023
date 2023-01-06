import { Component } from '@angular/core';
import { IProduct } from './product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})

export class ProductComponent{
  displayedColumns: string[] = ['name', 'brand', 'price', 'store'];
  products : IProduct[] = [
    {name: 'Crackers', brand: 'Wasa', price: 3.5, store: 'Carrefour MZ'},
    {name: 'Druiven pitloos', brand: 'Carrefour Bio', price: 1.15, store: 'Carrefour MZ'},
    {name: 'Speltwafels', brand: 'Bio', price: 1.49, store: 'Aldi'},
    {name: 'Citroensap', brand: 'Regalo', price: 0.49, store: 'Aldi'},
    {name: 'Ketchup', brand: 'Carrefour Simple', price: 1.49, store: 'Carrefour MZ'},
    {name: 'Wodka', brand: 'Imperial', price: 10.99, store: 'Carrefour MZ'},
  ];
}
