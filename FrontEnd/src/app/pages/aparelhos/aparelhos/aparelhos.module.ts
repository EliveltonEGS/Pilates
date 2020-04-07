import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { AparelhosRoutingModule } from './aparelhos-routing.module';
import { AparelhoListComponent } from '../aparelho-list/aparelho-list.component';
import { AparelhoFormComponent } from '../aparelho-form/aparelho-form.component';


@NgModule({
  declarations: [AparelhoListComponent, AparelhoFormComponent],
  imports: [
    CommonModule,
    AparelhosRoutingModule,
    ReactiveFormsModule
  ]
})
export class AparelhosModule { }
