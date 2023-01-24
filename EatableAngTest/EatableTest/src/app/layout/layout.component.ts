import { Component, ViewChild } from '@angular/core';
import { MatMenuTrigger } from '@angular/material/menu';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})

export class LayoutComponent { @ViewChild(MatMenuTrigger)
    trigger!: MatMenuTrigger;
  
    someMethod() {
      this.trigger.openMenu();
}
}

