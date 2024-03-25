import { Component } from '@angular/core';
import { DataService } from '../data.service';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrl: './forms.component.css',
  // template: `
  // <form [formGroup]="form" (ngSubmit)="onSubmit()">
  //   <div *ngFor="let key of keysAPi">
  //     <label for="">{{key}}</label>
  //     <input type="text" name="" id="">
  //   </div>
  //   <button type="submit">Enviar</button>
  // </form>
  // `
})
export class FormsComponent {
  keysAPi: any;
  form: FormGroup;

  constructor(private dataService: DataService,private formBuilder: FormBuilder) { 
    this.form = this.formBuilder.group({});
  }

  ngOnInit(): void {
    this.dataService.getFirstData().subscribe(data => {
      this.keysAPi = Object.keys(data);
      console.log(this.keysAPi);
    });
    this.form = this.formBuilder.group({});
  }
  onSubmit() {
    console.log('Formulário enviado');
  }
}
