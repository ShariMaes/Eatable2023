import { ContactInformationType } from "./enums/contactInformationType";

export interface IContactInformation {
    contactId: string;
    objectId: string;
    contactInformationType: ContactInformationType;
    contactInfo: string;
}