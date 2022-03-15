import { Component, OnInit, ViewChild } from '@angular/core';
import { ChartConfiguration, ChartData, ChartEvent, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';
import { Faltas } from 'src/app/models/faltas.model';
import { FaltasService } from 'src/app/services/faltas.service';


@Component({
  selector: 'app-bar-chart',
  templateUrl: './bar-chart.component.html',
  styleUrls: ['./bar-chart.component.css'],
})
export class BarChartComponent implements OnInit {
  @ViewChild(BaseChartDirective) chart: BaseChartDirective | undefined;

  constructor(private _service: FaltasService) {
    this.barChartData={datasets: []};
  }

  ngOnInit(): void {

    this._service.getBookData().subscribe((x) => 
    {
      let chartData = new Array(12);

      let currentMonth=-1;
      x.forEach((element) => {
        currentMonth= new Date(element.date).getMonth();
        if (chartData[currentMonth] === undefined) {
          chartData[currentMonth] = element.number;
        } else {
          chartData[currentMonth] += element.number;
        }
      });


    this.barChartData = {
      labels: [
        'January',
        'February',
        'March',
        'April',
        'May',
        'June',
        'July',
        'August',
        'September',
        'October',
        'November',
        'December',
      ],
      datasets: [{ data: chartData, label: 'Faltas' }],
    };
    });

   

    

  }

  public barChartOptions: ChartConfiguration['options'] = {
    responsive: true,
    // We use these empty structures as placeholders for dynamic theming.
    scales: {
      x: {},
      y: {
        min: 10,
      },
    },
    plugins: {
      legend: {
        display: true,
      },
    },
  };
  public barChartType: ChartType = 'bar';

  public barChartData: ChartData<'bar'>;

  // events
  public chartClicked({
    event,
    active,
  }: {
    event?: ChartEvent;
    active?: {}[];
  }): void {
    console.log(event, active);
  }

  public chartHovered({
    event,
    active,
  }: {
    event?: ChartEvent;
    active?: {}[];
  }): void {
    console.log(event, active);
  }
}
