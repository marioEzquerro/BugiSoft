import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-forbidden-url-component',
  templateUrl: './forbidden-url-component.component.html',
  styleUrls: ['./forbidden-url-component.component.css'],
})
export class ForbiddenUrlComponentComponent implements OnInit {
  constructor(private _location: Location) {}

  backClicked() {
    this._location.back();
  }

  ngOnInit(): void {}
}
