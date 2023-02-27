import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { ProductComponent } from './product/product.component';
import { StoreComponent } from './product/store/store.component';

const routes: Routes = [
  /*{path: 'layout', loadChildren: () => import('./layout/layout.module').then(m => m.LayoutModule)}*/
  {path: 'layout', component: LayoutComponent},
  {path: 'product', component: ProductComponent},
  {path: 'stores', component: StoreComponent},
  {path: 'stores/getStoreById/:id', component: StoreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
