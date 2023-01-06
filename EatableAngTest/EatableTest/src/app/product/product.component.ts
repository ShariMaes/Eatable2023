import { Component } from '@angular/core';
import { IProduct } from './product';
import { ProductService } from './product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})

export class ProductComponent{
  displayedColumns: string[] = ['productName', 'isFood', 'categorie', 
  'subcategorie', 'brand', 'store', 'volumePerUnit', 'weight',
  'unit', 'pricePerUnit', 'pricePerWeight', 'addedDate'];
  products : IProduct[] = [];


constructor(private productService: ProductService){}

ngOnInit(): void{
  this.productService.getProducts().subscribe({
    next: products => this.products = products 
  });
  }

}
