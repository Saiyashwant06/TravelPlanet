import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DelpopComponent } from './delpop.component';

describe('DelpopComponent', () => {
  let component: DelpopComponent;
  let fixture: ComponentFixture<DelpopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DelpopComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DelpopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
