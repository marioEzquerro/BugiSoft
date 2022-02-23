import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-input-filter',
  templateUrl: './input-filter.component.html',
  styleUrls: ['./input-filter.component.css'],
})
export class InputFilterComponent implements OnInit {
  constructor() {
    this.likes = 0;
  }

  likes: number;

  addLike() {
    this.likes++;
  }

  inputValue = new FormControl();

  ngOnInit(): void {}
}
