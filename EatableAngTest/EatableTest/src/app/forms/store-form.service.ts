import { Injectable } from "@angular/core";
import { FormControl, FormGroup } from "@angular/forms";
import { IStore } from "../models/store";
import { StringKeyValueHelper } from "../models/string-key-value-helper";
import { BaseForm } from "./base-form";

@Injectable({ providedIn: 'root' })

export class StoreFormService implements BaseForm {
    constructor() { }
    getNewForm(): FormGroup<StoreForm> {
        return new FormGroup<StoreForm>({
            inputStoreName: new FormControl<string>(null),
            inputAddressstreet: new FormControl<string>(null),
            inputAddresshouseNumber: new FormControl<string>(null),
            inputAddresspostalcode: new FormControl<string>(null),
            inputAddresscity: new FormControl<string>(null),
            inputStoreType: new FormControl<StringKeyValueHelper>(null),
            inputOpeningHours: new FormControl<string>(null),
            inputcontactInformationType: new FormControl<StringKeyValueHelper>(null),
            inputcontactInfo: new FormControl<string>(null)
        }, {updateOn: "change"})
    }

    setForm(form: FormGroup<StoreForm>, store: IStore): void {
        form.controls.inputStoreName.patchValue(store.storeName);
        form.controls.inputAddressstreet.patchValue(store.address?.street);
        form.controls.inputAddresshouseNumber.patchValue(store.address?.houseNumber);
        form.controls.inputAddresspostalcode.patchValue(store.address?.postalcode);
        form.controls.inputAddresscity.patchValue(store.address?.city);  
        form.controls.inputOpeningHours.patchValue(store.openingHours);
        // form.controls.inputcontactInformationType.patchValue(store.contactInformation);
        // form.controls.inputcontactInfo.patchValue(store.contactInformation);

        const storeTypeHelper: StringKeyValueHelper = {
            key: store.storeType,
            keyEnum: store.storeType,
            value: store.storeType
        }
        form.controls.inputStoreType.patchValue(storeTypeHelper);

    }

}

export interface StoreForm {
    inputStoreName: FormControl<string>;
    inputAddressstreet: FormControl<string>;
    inputAddresshouseNumber: FormControl<string>;
    inputAddresspostalcode: FormControl<string>;
    inputAddresscity: FormControl<string>;
    inputStoreType: FormControl<StringKeyValueHelper>;
    inputOpeningHours: FormControl<string>;
    inputcontactInformationType: FormControl<StringKeyValueHelper>;
    inputcontactInfo: FormControl<string>;
}