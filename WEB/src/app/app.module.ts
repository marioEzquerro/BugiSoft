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
import { CreateBookComponent } from './components/create-book/create-book.component';
import { NgChartsModule } from 'ng2-charts';
import { ChartComponent } from './pages/chart/chart.component';
import { LineChartComponent } from './components/line-chart/line-chart.component';
import { BarChartComponent } from './components/bar-chart/bar-chart.component';
import { FaltasService } from './services/faltas.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    InputFilterComponent,
    ListBooksComponent,
    CreateBookComponent,
    ChartComponent,
    LineChartComponent,
    BarChartComponent,
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
  providers: [BookService, FaltasService],
  bootstrap: [AppComponent],
})
export class AppModule {}
