import { Component, Input, OnInit } from "@angular/core";
import { UntypedFormControl, UntypedFormGroup } from "@angular/forms";
import { ActivatedRoute } from "@angular/router";
import { BaseComponent } from "src/app/base/base.component";
import { StoreFormService, StoreForm } from "src/app/forms/store-form.service";
import { StoreModalService } from "src/app/modals/store/store-modal.service";
import { IStore } from "src/app/models/store";
import { ProductService } from "../../../services/product.service";

@Component({
    selector: 'app-store-create',
    templateUrl: './store-create.component.html',
    styleUrls: ['./store-create.component.css']
})

export class StoreCreateComponent extends BaseComponent implements OnInit {
    constructor(
        private productService: ProductService,
        private route: ActivatedRoute,
        private readonly storeModalService: StoreModalService,
        private readonly storeFormService: StoreFormService

    ) {super();}

    @Input()
    readOnlyMode: string;

    @Input()
    storeToShow: IStore | undefined;

    public storeForm: UntypedFormGroup;

    async ngOnInit(): Promise<void> {
        await this.createForm();

        if (this.storeToShow != undefined) {
            await this.setData(this.storeToShow);
        }

        if (this.readOnlyMode == "NotActive") {
            await this.enableAllFormFields(this.storeForm);
        } else {
            await this.disableAllFormFields(this.storeForm);
        }
    }

    private async createForm(): Promise<void> {
        this.storeForm = this.storeFormService.getNewForm();
    }

    private async setData(store: IStore): Promise<void> {
        this.storeFormService.setForm(this.storeForm, store);
    }

    private async disableAllFormFields(formGroup: UntypedFormGroup): Promise<void> {
        Object.keys(formGroup.controls).forEach(field => {
            const control = formGroup.get(field);
            if (control instanceof UntypedFormControl) {
                control.disable();
            } else if (control instanceof UntypedFormGroup) {
                this.disableAllFormFields(control);
            }
        });
    };

    private async enableAllFormFields(formGroup: UntypedFormGroup): Promise<void> {
        Object.keys(formGroup.controls).forEach(field => {
            const control = formGroup.get(field);
            if (control instanceof UntypedFormControl) {
                control.enable();
            } else if (control instanceof UntypedFormGroup) {
                this.enableAllFormFields(control);
            }
        });
    };

    public async onStoreFormSubmit(): Promise<void> {
        const form = this.storeForm as UntypedFormGroup;
        var store: IStore = this.storeToShow;

        //store.storeName = form.controls.inputStoreName.value;


        //save
    };

}

