import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AparelhosModule } from './pages/aparelhos/aparelhos/aparelhos.module';


const routes: Routes = [
  {path: 'aparelhos', loadChildren: () => AparelhosModule}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
