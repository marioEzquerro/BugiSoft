import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoticiasPageComponent } from './noticias-page.component';

describe('NoticiasPageComponent', () => {
  let component: NoticiasPageComponent;
  let fixture: ComponentFixture<NoticiasPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoticiasPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NoticiasPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
