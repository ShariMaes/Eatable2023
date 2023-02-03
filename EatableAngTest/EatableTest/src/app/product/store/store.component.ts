import { Component } from "@angular/core";
import { IStore } from "src/app/models/store";
import { ProductService } from "../product.service";

@Component({
    selector: 'app-store',
    templateUrl: './store.component.html',
    styleUrls: ['./store.component.css']
  })

export class StoreComponent {

    displayedColumns: string[] = [
        'storeIdentifier'
        ,'storeName'    
    ];
  
    stores: IStore[] = [];
    filteredStores: IStore[] = [];
  
    private _listFilter: string = '';
    get listFilter(): string {
      return this._listFilter;
    }
    set listFilter(value: string) {
      this._listFilter = value;
      console.log('in setter: ', value);
      this.filteredStores = this.performFilter(value);
    }

    value: string[] = [];
    valueOptions: string[] = [];
   
    constructor(private productService: ProductService) { }
  
    ngOnInit(): void {
      this.productService.getStores().subscribe({
        next: stores => {
          this.stores = stores;
          this.filteredStores = this.stores;
        }
      });
    }
  
    performFilter(filterBy: string): IStore[] {
      filterBy = filterBy.toLocaleLowerCase();
      return this.stores.filter((product: IStore) => product.storeName.toLocaleLowerCase().includes(filterBy));
    }
  
  }