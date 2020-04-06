import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AparelhoListComponent } from '../aparelho-list/aparelho-list.component';
import { AparelhoFormComponent } from './../aparelho-form/aparelho-form.component';

const routes: Routes = [
  {path: '', component: AparelhoListComponent},
  {path: 'novo', component: AparelhoFormComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AparelhosRoutingModule { }
