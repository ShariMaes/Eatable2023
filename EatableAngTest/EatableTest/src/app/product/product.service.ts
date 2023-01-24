import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IProduct } from "./product";

@Injectable({providedIn: 'root'})

export class ProductService{
    private productUrl = 'files/productlist.json';

    constructor(private http: HttpClient) {     
    }

    getProducts(): Observable<IProduct[]> {
        return this.http.get<IProduct[]>(this.productUrl)
    }
}