import { Component, HostListener, OnInit } from '@angular/core';
import * as chart from 'chart.js';

@Component({
  selector: 'app-sales-plot',
  templateUrl: './sales-plot.component.html',
  styleUrls: ['./sales-plot.component.scss'],
})
export class SalesPlotComponent implements OnInit {
  res: any[] = [];
  constructor() {
    //@ts-ignore
    console.log(chart.registerables);
    //@ts-ignore
    chart.Chart.register(...chart.registerables);
  }
  ngOnInit(): void {
    var plot = document.getElementById('plot') as HTMLCanvasElement;
    const ctx = plot.getContext('2d') as CanvasRenderingContext2D;
    var charts = new chart.Chart(ctx, {
      type: 'line',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [
          {
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: 'rgba(50, 159, 64, 0.2)',

            borderColor: 'rgba(0, 99, 132, 1)',
            borderWidth: 1,
          },
          {
            label: '# of Votes',
            data: [15, 22, 3, 8, 5, 6],
            backgroundColor: 'rgba(54, 162, 235, 0.2)',
            borderColor: 'rgba(54, 162, 235, 1)',

            borderWidth: 1,
          },
        ],
      },
      options: {
        scales: {},
        onResize: (newSize: any): void => {
          console.log(chart, newSize);
        },
      },
    });
    var plot2 = document.getElementById('plot2') as HTMLCanvasElement;
    const ctx2 = plot2.getContext('2d') as CanvasRenderingContext2D;
    var charts2 = new chart.Chart(ctx2, {
      type: 'bar',
      data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [
          {
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: 'rgba(50, 159, 64, 0.2)',

            borderColor: 'rgba(0, 99, 132, 1)',
            borderWidth: 1,
          },
          {
            label: '# of Votes',
            data: [15, 22, 3, 8, 5, 6],
            backgroundColor: 'rgba(54, 162, 235, 0.2)',
            borderColor: 'rgba(54, 162, 235, 1)',

            borderWidth: 1,
          },
        ],
      },
      options: {
        scales: {},
        onResize: (newSize: any): void => {
          console.log(chart, newSize);
        },
      },
    });

    this.res = [charts, charts2];
  }
  @HostListener('window:resize', ['$event'])
  resized(t: any) {
    if (this.res) {
      this.res.forEach((e) => e.resize());
    }
  }
}
