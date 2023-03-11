import { Component, OnDestroy } from "@angular/core";
import { Subscription } from "rxjs";

@Component({
    selector: 'app-base',
    templateUrl: './base.component.html',
    styleUrls: ['./base.component.css']
})

export class BaseComponent implements OnDestroy {
    protected subscriptions: Subscription[] = [];

    constructor() { }

    ngOnDestroy(): void {
       this.subscriptions.forEach(s => s.unsubscribe())
    }
}