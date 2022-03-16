import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ForbiddenUrlComponentComponent } from './components/forbidden-url-component/forbidden-url-component.component';
import { BibliotecaPageComponent } from './pages/home/biblioteca-page/biblioteca-page.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ItemJuegoComponent } from './pages/home/item-juego/item-juego.component';
import { NoticiasPageComponent } from './pages/home/noticias-page/noticias-page.component';

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
    path: 'noticias',
    component: NoticiasPageComponent,
  },
  {
    path: 'juegos/:idJuego',
    component: ItemJuegoComponent,
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
