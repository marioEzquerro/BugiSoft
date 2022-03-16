import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemJuegoComponent } from './item-juego.component';

describe('ItemJuegoComponent', () => {
  let component: ItemJuegoComponent;
  let fixture: ComponentFixture<ItemJuegoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ItemJuegoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemJuegoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
