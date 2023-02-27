import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProductComponent } from './product/product.component';
import { LayoutComponent } from './layout/layout.component';
import { LayoutModule } from './layout/layout.module';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { StoreComponent } from './product/store/store.component';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { StoreCreateComponent } from './product/store/store-create/store-create.component';
import { StoreEditComponent } from './product/store/store-edit/store-edit.component';
import { StoreDetailComponent } from './product/store/store-detail/store-detail.component';
import { StoreModalComponent } from './modals/store/store-modal.component';

@NgModule({
  declarations: [
    LayoutComponent,
    AppComponent,
    ProductComponent,
    StoreComponent,
    StoreCreateComponent,
    StoreDetailComponent,
    StoreEditComponent,
    StoreModalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    RouterModule,
    LayoutModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    MatIconModule,
    BrowserModule,
    MatButtonModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
