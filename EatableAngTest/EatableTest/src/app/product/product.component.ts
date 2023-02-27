import { Component, ViewChild } from '@angular/core';
import { IProduct } from './product';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})

export class ProductComponent {
  displayedColumns: string[] = ['productName',  'categorie',
     'brand', 'store', 'volumePerUnit', 'pricePerUnit', 'pricePerWeight', 'addedDate'];

  products: IProduct[] = [];
  filteredProducts: IProduct[] = [];

  private _listFilter: string = '';
  get listFilter(): string {
    return this._listFilter;
  }
  set listFilter(value: string) {
    this._listFilter = value;
    console.log('in setter: ', value);
    this.filteredProducts = this.performFilter(value);
  }

  value: string[] = [];
  valueOptions: string[] = [];
  stores: string[] = [
    "Carrefour MZ",
    "Lidl Zemst",
    "Aldi Zemst",
    "Jumbo Ranst",
    "Crisp",
    "Aveve",
    "Body&Fit",
    "Albert Heijn Levering",
    "Albert Heijn Malinas",
    "Koopjesdrogisterij.nl",
    "Colruyt Mechelen",
    "De Nieuwe Maalder",
    "Kruidvat",
    "Pit&Pit",
    "Lidl Malinas",
    "De Notenshop",
    "Action Malinas",
    "Bio Planet",
    "Bol.com",
    "Makro",
    "Kruideniersstore.be",
    "Farmaline",
    "MyProtein",
    "Colruyt Mechelen",
    "Spar Hofstade"
  ].sort();


  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.getProducts().subscribe({
      next: products => {
        this.products = products;
        this.filteredProducts = this.products;
      }
    });
  }


  performFilter(filterBy: string): IProduct[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product: IProduct) => product.productName.toLocaleLowerCase().includes(filterBy));
  }

}
