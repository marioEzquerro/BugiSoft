import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ForbiddenUrlComponentComponent } from './components/forbidden-url-component/forbidden-url-component.component';
import { BibliotecaPageComponent } from './pages/home/biblioteca-page/biblioteca-page.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponentComponent,
  },
  {
    path: 'biblioteca',
    component: BibliotecaPageComponent,
  },
  {
    path: '**',
    component: ForbiddenUrlComponentComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
