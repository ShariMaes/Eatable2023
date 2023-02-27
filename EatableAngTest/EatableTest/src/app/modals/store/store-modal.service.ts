import { Injectable } from '@angular/core';
import { NgbModal , NgbModalOptions} from '@ng-bootstrap/ng-bootstrap';
import { IStore } from '../../models/store';
import { StoreModalComponent } from './store-modal.component';

@Injectable({
    providedIn: 'root'
})

export class StoreModalService {
    constructor(private modalService: NgbModal) { }

    public async openStoreModal(store?: IStore, readOnlyMode?: string): Promise<IStore> {
        const config: NgbModalOptions = {
            backdrop: 'static',
            size: 'lg',
            windowClass: 'my-class'
        };

        const modalRef = this.modalService.open(StoreModalComponent, config);
        modalRef.componentInstance.storeToShow = store;
        modalRef.componentInstance.readOnlyMode = readOnlyMode;
        return await modalRef.result.then((result: IStore) => {
            console.log('Results', result);
            return result;
        })
    }
}