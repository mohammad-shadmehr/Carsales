import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AddUpdateCarDialog } from './add-update-car-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'car',
  templateUrl: './car.component.html'
})
export class CarComponent {
  public cars: ICarDto[];
  baseUrl = 'https://localhost:44391/api/Car/';
  displayedColumns: string[] = ['id', 'make', 'model', 'bodyType', 'engine', 'numberOfWheels', 'numberOfDoors', 'actions'];

  constructor(public dialog: MatDialog, public http: HttpClient) {
    this.load();
  }

  load() {
    this.http.get<ICarDto[]>(`${this.baseUrl}GetAll`).subscribe(result => {
      this.cars = result;
    }, error => console.error(error));
  }

  delete(car: ICarDto) {
    this.http.delete(`${this.baseUrl}Delete?id=${car.id}`).subscribe(() => {
      this.load();
    }, error => console.error(error));
  }

  showDialog(car?: ICarDto) {
    const dialogRef = this.dialog.open(AddUpdateCarDialog, {
      width: '500px',
      data: car || new CarDto()
    });

    dialogRef.afterClosed().subscribe(result => {
      this.load();
    });
  }
}

export interface ICarDto {
  id: number;
  model: string;
  make: string;
  numberOfDoors: number;
  numberOfWheels: number;
  bodyType: string;
  engine: string;
}

export class CarDto implements ICarDto {
  id: number;
  model: string;
  make: string;
  numberOfDoors: number;
  numberOfWheels: number;
  bodyType: string;
  engine: string;
}
