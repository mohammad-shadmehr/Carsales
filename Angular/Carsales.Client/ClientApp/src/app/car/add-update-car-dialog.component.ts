import { Component, Inject } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CarComponent, ICarDto } from './car.component';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'add-update-car-dialog',
  templateUrl: 'add-update-car-dialog.component.html',
})
export class AddUpdateCarDialog {
  baseUrl = 'https://localhost:44391/api/Car/';

  constructor(
    public dialogRef: MatDialogRef<CarComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ICarDto, public http: HttpClient) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  save() {
    this.http.post(`${this.baseUrl}AddOrUpdate`, this.data).subscribe(() => {
      this.dialogRef.close();
    }, error => {
        alert('An error occurred and no data was saved!');
    });
  }
}
