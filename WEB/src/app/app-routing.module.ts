import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateBookComponent } from './components/create-book/create-book.component';
import { ChartComponent } from './pages/chart/chart.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponentComponent,
  },
  {
    path: 'create',
    component: CreateBookComponent,
  },
  {
    path: 'chart',
    component: ChartComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
