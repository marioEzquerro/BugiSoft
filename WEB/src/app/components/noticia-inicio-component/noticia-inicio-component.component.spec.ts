import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NoticiaInicioComponentComponent } from './noticia-inicio-component.component';

describe('NoticiaInicioComponentComponent', () => {
  let component: NoticiaInicioComponentComponent;
  let fixture: ComponentFixture<NoticiaInicioComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NoticiaInicioComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NoticiaInicioComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
