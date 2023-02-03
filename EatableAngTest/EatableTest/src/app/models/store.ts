import { IAddress } from "./address";
import { IContactInformation } from "./contactInformation";
import { StoreType } from "./enums/storeType";

export interface IStore {

    storeId: string;
    storeIdentifier: string;
    storeName: string;
    address?: IAddress;
    storeType: StoreType;
    openingHours?: string;
    contactInformation?: Array<IContactInformation>;
  }