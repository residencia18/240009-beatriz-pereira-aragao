import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { StorageService } from '../service/storage.service';
import { IPig, IWeights } from '../model/usuario.model';

@Component({
  selector: 'app-cadastro-suino',
  templateUrl: './cadastro-suino.component.html',
  styleUrls: ['./cadastro-suino.component.css'],
})
export class CadastroSuinoComponent implements OnInit {
  cadastroForm = new FormGroup({
    brincoAnimal: new FormControl('', [
      Validators.required,
      Validators.pattern('^[0-9]*$'),
    ]),
    brincoPai: new FormControl('', [
      Validators.required,
      Validators.pattern('^[0-9]*$'),
    ]),
    brincoMae: new FormControl('', [
      Validators.required,
      Validators.pattern('^[0-9]*$'),
    ]),
    dataNascimento: new FormControl('', Validators.required),
    dataSaida: new FormControl('', Validators.required),
    status: new FormControl('', Validators.required),
    sexo: new FormControl('', Validators.required),
    peso: new FormControl('', Validators.required),
  });

  constructor(private storageService: StorageService) {}

  ngOnInit(): void {}

  onSubmit(): void {
    const formValue = this.cadastroForm.value;
    const userData = localStorage.getItem('userData');
    const cadastro: IPig = {
      idPig: formValue.brincoAnimal || '',
      fatherEarTag: formValue.brincoPai || '',
      motherEarTag: formValue.brincoMae || '',
      dateOfBirth: formValue.dataNascimento || '',
      dateOfDeparture: formValue.dataSaida || '',
      gender:
        formValue.sexo === 'M' || formValue.sexo === 'F' ? formValue.sexo : 'M',
      status: formValue.status || '',
      idUser: userData ? JSON.parse(userData).id : '',
    };

    const peso: IWeights = {
      weight: formValue.peso ? parseFloat(formValue.peso) : 0,
      date: new Date().toISOString(),
      idPig: cadastro.idPig || '',
    };

    this.storageService.addCadastroSuino(cadastro);
    if (cadastro.idPig)
      this.storageService.addPesoToSuino(cadastro.idPig, peso);
  }
}
