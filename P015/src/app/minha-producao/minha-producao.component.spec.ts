import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MinhaProducaoComponent } from './minha-producao.component';

describe('MinhaProducaoComponent', () => {
  let component: MinhaProducaoComponent;
  let fixture: ComponentFixture<MinhaProducaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MinhaProducaoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MinhaProducaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
