import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { InputFilterComponent } from './components/input-filter/input-filter.component';
import { ListBooksComponent } from './components/list-books/list-books.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BookService } from './services/book.service';
import { NgChartsModule } from 'ng2-charts';
import { FaltasService } from './services/faltas.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { FormJuegoComponent } from './components/form-juego/form-juego.component';
import { FormNoticiaComponent } from './components/form-noticia/form-noticia.component';
import { NoticiaService } from './services/noicia.service';
import { BibliotecaPageComponent } from './pages/home/biblioteca-page/biblioteca-page.component';
import { ForbiddenUrlComponentComponent } from './components/forbidden-url-component/forbidden-url-component.component';
import { NavigationComponent } from './components/navigation/navigation.component';
import { FooterComponent } from './components/footer/footer.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    InputFilterComponent,
    ListBooksComponent,
    FormJuegoComponent,
    FormNoticiaComponent,
    BibliotecaPageComponent,
    ForbiddenUrlComponentComponent,
    NavigationComponent,
    FooterComponent
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
  providers: [BookService, FaltasService, NoticiaService],
  bootstrap: [AppComponent],
})
export class AppModule {}
