import { IAddress } from "./address";
import { IContactInformation } from "./contactInformation";
import { StoreType } from "./enums/storeType";

export interface IStore {

    storeId: string;
    storeIdentifier: string;
    storeName: string;
    address?: null | IAddress;
    storeType: StoreType;
    openingHours?: null | string;
    contactInformation?: null | Array<IContactInformation>;
  }