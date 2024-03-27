import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { StorageService } from '../service/storage.service';

@Component({
  selector: 'app-sessao',
  templateUrl: './sessao.component.html',
  styleUrl: './sessao.component.css'
})
export class SessaoComponent {
  cadastroForm = new FormGroup({
    data: new FormControl('', Validators.required),
    descricao: new FormControl('', Validators.required),
    brincoAnimal: new FormControl('', [
      Validators.required
    ])
  });

  constructor(private storageService: StorageService) {}
  listaBrincos: string[] = [];

  ngOnInit(): void {
    console.log(this.getBrincos);
  }

  onSubmit(): void {}

  getBrincos(){
    
    return this.storageService.listarSuinos
  }

  
}
