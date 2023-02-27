import { Routes } from "@angular/router";
import { StoreCreateComponent } from "./store-create/store-create.component";
import { StoreDetailComponent } from "./store-detail/store-detail.component";
import { StoreEditComponent } from "./store-edit/store-edit.component";

const routes: Routes = [
    {
        path: '',
        children: [
            {
                path: 'storedetail/:id',
                component: StoreDetailComponent,
                data: {
                    title: 'Detail'
                }
            },
            {
                path: 'storeedit/:id',
                component: StoreEditComponent,
                data: {
                    title: 'Edit'
                }
            },
            {
                path: 'storecreate',
                component: StoreCreateComponent,
                data: {
                    title: 'Create'
                 } 
            }
            
        ]
    }
]