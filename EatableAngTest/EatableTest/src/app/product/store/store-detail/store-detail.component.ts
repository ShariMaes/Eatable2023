import { Component, Input, OnInit } from "@angular/core";
import { BaseComponent } from "src/app/base/base.component";
import { IStore } from "src/app/models/store";

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

    @Input()
    readOnlyMode: string;

    @Input()
    storeToShow: IStore | undefined;

    public async ngOnInit(): Promise<void> {
       
    }
}

