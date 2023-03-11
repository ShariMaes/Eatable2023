import { Component, Input, OnInit } from "@angular/core";
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { BaseComponent } from "../../base/base.component";
import { IStore } from "../../models/store";
import { ProductService } from "../../services/product.service";
import { StoreComponent } from "src/app/product/store/store.component";
import { StoreModalService } from "./store-modal.service";

@Component({
  selector: 'app-store-modal',
  templateUrl: './store-modal.component.html',
  styleUrls: ['./store-modal.component.css']
})

export class StoreModalComponent extends BaseComponent implements OnInit {

  @Input()
  readOnlyMode: string;
  @Input()
  storeToShow: IStore | undefined;

  constructor(
    public readonly activeModal: NgbActiveModal,
    public readonly storeModalService: StoreModalService,
    public readonly productService: ProductService
  ) { super() }

  public async ngOnInit(): Promise<void> {
    if (this.storeToShow != undefined) {
      this.subscriptions.push(this.productService.getStoreById(this.storeToShow.storeId)
      .subscribe(store => {
          this.storeToShow = store;
      }));
    }
  }

  public toEdit(): void {
    this.storeModalService.openStoreModal(this.storeToShow, "NotActive");
  }

  public closeModal(): void {
      this.activeModal.close();
  }
}