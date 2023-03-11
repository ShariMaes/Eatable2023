import { Component, OnInit } from "@angular/core";
import { BaseComponent } from "src/app/base/base.component";
import { StoreModalService } from "src/app/modals/store/store-modal.service";
import { IStore } from "src/app/models/store";
import { ProductService } from "../../services/product.service";

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})

export class StoreComponent extends BaseComponent implements OnInit{

  displayedColumns: string[] = [
    //'storeIdentifier',
    'storeName',
    'storeDetail',
    'addShopping',
    'addPantry'
  ];

  stores: IStore[] = [];
  filteredStores: IStore[] = [];
  store: IStore | undefined;

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

  constructor(
    private productService: ProductService,
    private readonly storeModalService: StoreModalService
  ) { super() }

  ngOnInit(): void {
    this.productService.getStores().subscribe({
      next: stores => {
        this.stores = stores;
        this.filteredStores = this.stores;
      }
    });
  }

  toDetail(store: IStore) {
    this.storeModalService.openStoreModal(store, "Active");
  }

  toCreate() {
    this.storeModalService.openStoreModal(undefined, "NotActive");
  }

  performFilter(filterBy: string): IStore[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.stores.filter((store: IStore) => store.storeName.toLocaleLowerCase().includes(filterBy));
  }

}