import { Component, Input, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { BaseComponent } from "src/app/base/base.component";
import { IStore } from "src/app/models/store";
import { ProductService } from "../../../services/product.service";

@Component({
    selector: 'app-store-edit',
    templateUrl: './store-edit.component.html',
    styleUrls: ['./store-edit.component.css']
})

export class StoreEditComponent extends BaseComponent implements OnInit{
    constructor(
        private productService: ProductService) 
        {super();}

    @Input()
    readOnlyMode:string;

    @Input()
    storeToShow: IStore | undefined;

    public async ngOnInit(): Promise<void> {
        if (this.storeToShow != undefined) {
           this.subscriptions.push(this.productService.getStoreById(this.storeToShow.storeId)
                .subscribe(store => {
                    this.storeToShow = store;
                }));
        }
    }

}