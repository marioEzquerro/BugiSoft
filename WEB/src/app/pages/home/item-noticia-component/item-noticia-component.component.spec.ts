import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemNoticiaComponentComponent } from './item-noticia-component.component';

describe('ItemNoticiaComponentComponent', () => {
  let component: ItemNoticiaComponentComponent;
  let fixture: ComponentFixture<ItemNoticiaComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ItemNoticiaComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemNoticiaComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
