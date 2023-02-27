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
        private productService: ProductService,
        private route: ActivatedRoute) {
        super();
    }
    

    public readOnlyMode = "false";

    @Input()
    storeToShow: IStore | undefined;

    store: IStore | undefined;

    ngOnInit(): void {
        var id = this.route.snapshot.params['storeId'];
        this.subscriptions.push(this.productService.getStoreById(id)
            .subscribe(store => {
                this.store = store;
            }));
    }

}