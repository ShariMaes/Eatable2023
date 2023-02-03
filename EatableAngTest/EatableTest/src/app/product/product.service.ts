import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IStore } from "../models/store";
import { IProduct } from "./product";

@Injectable({providedIn: 'root'})

export class ProductService{
    private productUrl = 'files/productlist.json';
    private getStoreList = 'https://localhost:44368/store/GetStoreList';
    private getStoreById = 'files/productlist.json';
    private getStoreByIdentifier = 'files/productlist.json';

    constructor(private http: HttpClient) {     
    }

    getProducts(): Observable<IProduct[]> {
        return this.http.get<IProduct[]>(this.productUrl)
    }

    getStores(): Observable<IStore[]> {
        return this.http.get<IStore[]>(this.getStoreList)
    }

    getStore(): Observable<IStore[]> {
        return this.http.get<IStore[]>(this.productUrl)
    }
}