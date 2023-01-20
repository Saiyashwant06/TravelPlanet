import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResUsersComponent } from './res-users.component';

describe('ResUsersComponent', () => {
  let component: ResUsersComponent;
  let fixture: ComponentFixture<ResUsersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ResUsersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ResUsersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
