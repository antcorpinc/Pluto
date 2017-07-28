import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthenticatedUserComponent } from './authenticated-user.component';

describe('AuthenticatedUserComponent', () => {
  let component: AuthenticatedUserComponent;
  let fixture: ComponentFixture<AuthenticatedUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AuthenticatedUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthenticatedUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
