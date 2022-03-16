import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ForbiddenUrlComponentComponent } from './forbidden-url-component.component';

describe('ForbiddenUrlComponentComponent', () => {
  let component: ForbiddenUrlComponentComponent;
  let fixture: ComponentFixture<ForbiddenUrlComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ForbiddenUrlComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ForbiddenUrlComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
