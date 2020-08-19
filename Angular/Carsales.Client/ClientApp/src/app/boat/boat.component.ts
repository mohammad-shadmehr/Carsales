import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AddUpdateBoatDialog } from './add-update-boat-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'boat',
  templateUrl: './boat.component.html'
})
export class BoatComponent {
  public boats: IBoatDto[];
  baseUrl = 'https://localhost:44391/api/Boat/';
  displayedColumns: string[] = ['id', 'model', 'make', 'category', 'segment', 'actions'];

  constructor(public dialog: MatDialog, public http: HttpClient) {
    this.load();
  }

  load() {
    this.http.get<IBoatDto[]>(`${this.baseUrl}GetAll`).subscribe(result => {
      this.boats = result;
    }, error => console.error(error));
  }

  delete(boat: IBoatDto) {
    this.http.delete(`${this.baseUrl}Delete?id=${boat.id}`).subscribe(() => {
      this.load();
    }, error => console.error(error));
  }

  showDialog(boat?: IBoatDto) {
    const dialogRef = this.dialog.open(AddUpdateBoatDialog, {
      width: '500px',
      data: boat || new BoatDto()
    });

    dialogRef.afterClosed().subscribe(result => {
      this.load();
    });
  }
}

export interface IBoatDto {
  id: number;
  model: string;
  make: string;
  category: string;
  segment: string;
}

export class BoatDto implements IBoatDto {
  id: number;
  model: string;
  make: string;
  category: string;
  segment: string;
}
