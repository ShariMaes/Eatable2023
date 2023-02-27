import { Component, Input, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { BaseComponent } from "src/app/base/base.component";
import { StoreModalService } from "src/app/modals/store/store-modal.service";
import { IStore } from "src/app/models/store";
import { ProductService } from "../../../services/product.service";

@Component({
    selector: 'app-store-create',
    templateUrl: './store-create.component.html',
    styleUrls: ['./store-create.component.css']
})

export class StoreCreateComponent extends BaseComponent implements OnInit{

    constructor(
        private productService: ProductService,
        private route: ActivatedRoute,
        private readonly storeModalService: StoreModalService
    ) {
        super();
    }

    @Input()
    readOnlyMode = "";

    @Input()
    storeToShow: IStore | undefined;

    ngOnInit(): void {

    }
}

