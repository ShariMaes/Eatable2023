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
  store: IStore | undefined;
  @Input()
  readOnlyMode: string | undefined;

  public storeToShow: IStore | undefined;
  public enabled: boolean = true;

  constructor(
    public readonly activeModal: NgbActiveModal,
    public readonly storeModalService: StoreModalService
  ) { super() }


  ngOnInit(): void {

    if (this.storeToShow != undefined) {
      this.store = this.storeToShow;
      if (this.readOnlyMode == 'true') {
        this.enabled = false
      }
    }

  }

  public toEdit(): void {
    this.storeModalService.openStoreModal(this.store, "false");
  }

  public closeModal(): void {

      this.activeModal.close();
    
  }
}