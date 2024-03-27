export class Usuario {
  constructor(
    public email: string,
    public id: string,
    private _token: string,
    private _tokenExpirationDate: Date
  ) {}

  get token() {
    if (!this._tokenExpirationDate || new Date() > this._tokenExpirationDate) {
      return null;
    }
    return this._token;
  }
}

export interface IUser {
  name: string;
  nameFarm: string;
  email: string;
  Piggers?: IPig[];
}

export interface IPig {
  idPig?: string;
  fatherEarTag: string;
  motherEarTag: string;
  dateOfBirth: string;
  dateOfDeparture: string;
  status: string;
  gender: 'M' | 'F';
  idUser: string;
  weights?: IWeights[];
}

export interface IWeights {
  id?: string;
  idPig: string;
  weight: number;
  date: string;
}
