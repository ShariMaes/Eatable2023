import { Component, Input, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { BaseComponent } from "src/app/base/base.component";
import { IStore } from "src/app/models/store";
import { ProductService } from "../../../services/product.service";
import { StoreComponent } from "../store.component";

@Component({
    selector: 'app-store-detail',
    templateUrl: './store-detail.component.html',
    styleUrls: ['./store-detail.component.css']
})

export class StoreDetailComponent extends BaseComponent implements OnInit{

    constructor(
       ) {
        super();
    }


    public readOnlyMode = "true";

    @Input()
    storeToShow: IStore | undefined;

    ngOnInit(): void {
       
    }
}

