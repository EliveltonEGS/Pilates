import { AparelhoFormComponent } from './../aparelho-form/aparelho-form.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AparelhosRoutingModule } from './aparelhos-routing.module';
import { AparelhoListComponent } from './../aparelho-list/aparelho-list.component';

@NgModule({
  declarations: [AparelhoListComponent, AparelhoFormComponent],
  imports: [
    CommonModule,
    AparelhosRoutingModule,
  ]
})
export class AparelhosModule { }
