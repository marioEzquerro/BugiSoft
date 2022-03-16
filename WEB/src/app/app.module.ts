import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { InputFilterComponent } from './components/input-filter/input-filter.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgChartsModule } from 'ng2-charts';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { FormJuegoComponent } from './components/form-juego/form-juego.component';
import { FormNoticiaComponent } from './components/form-noticia/form-noticia.component';
import { NoticiaService } from './services/noticia.service';
import { BibliotecaPageComponent } from './pages/home/biblioteca-page/biblioteca-page.component';
import { ForbiddenUrlComponentComponent } from './components/forbidden-url-component/forbidden-url-component.component';
import { NavigationComponent } from './components/navigation/navigation.component';
import { FooterComponent } from './components/footer/footer.component';
import { NoticiasPageComponent } from './pages/home/noticias-page/noticias-page.component';
import { JuegoService } from './services/juego.service';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    InputFilterComponent,
    FormJuegoComponent,
    FormNoticiaComponent,
    BibliotecaPageComponent,
    ForbiddenUrlComponentComponent,
    NavigationComponent,
    FooterComponent,
    NoticiasPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgChartsModule,
    BrowserAnimationsModule,
    MatSliderModule
  ],
  providers: [JuegoService, NoticiaService, JuegoService],
  bootstrap: [AppComponent],
})
export class AppModule {}
